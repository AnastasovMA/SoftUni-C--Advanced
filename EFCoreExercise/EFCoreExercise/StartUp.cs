using EFCoreExercise;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftUni
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();
            var employees = GetEmployeesFullInformation(dbContext);
            var employees2 = GetEmployeesWithSalaryOver50000(dbContext);
            var employees3 = GetEmployeesFromResearchAndDevelopment(dbContext);
            var employees4 = AddNewAddressToEmployee(dbContext);
            var employees5 = GetEmployeesInPeriod(dbContext);
            var employees6 = GetAddressesByTown(dbContext);
            var employees7 = GetEmployee147(dbContext);
            var departments = GetDepartmentsWithMoreThan5Employees(dbContext);
            var projects = GetLatestProjects(dbContext);
            var salary = IncreaseSalaries(dbContext);

            //Console.WriteLine(employees);
            //Console.WriteLine(employees2);
            //Console.WriteLine(employees3);
            //Console.WriteLine(employees4);
            //Console.WriteLine(employees6);
            //Console.WriteLine(employees7);
            //Console.WriteLine(departments);
            //Console.WriteLine(projects);
            Console.WriteLine(salary);
        }
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            string result = string.Empty;
            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
                {
                    Name = $"{e.FirstName} {e.LastName} {e.MiddleName}",
                    JobTitle = e.JobTitle,
                    Salary = $"{e.Salary:f2}"
                })
           .ToList();

            foreach (var employee in employees)
            {
                result += $"{employee.Name} {employee.JobTitle} {employee.Salary}\n";
            }
            return result;
        }
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees
                .Where(e => e.Salary > 50000)
                .OrderBy(e => e.FirstName)
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Select(e => new
                {
                    Employee = $"{e.FirstName} {e.LastName} {e.Department.Name} - ${e.Salary:f2}"
                })
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine(employee.Employee);
            }
            return sb.ToString().TrimEnd();
        }
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var nakovNewAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };
            var nakovEmployee = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov");
            context.Addresses.Add(nakovNewAddress);
            nakovEmployee.Address = nakovNewAddress;

            context.SaveChanges();

            var sb = new StringBuilder();
            var employees = context.Addresses
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => new
                {
                    e.AddressText
                })
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine(employee.AddressText);
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var employees = context.Employees
                .Where(e => e.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFName = e.Manager.FirstName,
                    ManagerLName = e.Manager.LastName,
                    Projects = e.EmployeesProjects.Select(ep => new
                    {
                        projName = ep.Project.Name,
                        projStart = ep.Project.StartDate,
                        projEnd = ep.Project.EndDate,
                    })
                })
                .Take(10)
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFName} {employee.ManagerLName}");

                foreach (var project in employee.Projects)
                {
                    var projEnd = project.projEnd.HasValue ? project.projEnd.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    sb.AppendLine($"--{project.projName} - {project.projStart:M/d/yyyy h:mm:ss tt} - {projEnd}");
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context.Addresses
                .Select(e => new
                {
                    Address = e.AddressText,
                    Town = e.Town.Name,
                    Count = e.Employees.Count
                })
                .OrderByDescending(e => e.Count)
                .ThenBy(e => e.Town)
                .ThenBy(e => e.Address)
                .Take(10)
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.Address}, {employee.Town} - {employee.Count} employees");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployee147(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employee = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    Name = $"{e.FirstName} {e.LastName}",
                    Job = e.JobTitle,
                    Projects = e.EmployeesProjects
                    .OrderBy(ep => ep.Project.Name)
                    .Select(ep => new
                    {
                        projName = ep.Project.Name
                    })
                });

            foreach (var e in employee)
            {
                sb.AppendLine($"{e.Name} - {e.Job}");

                foreach (var project in e.Projects)
                {
                    sb.AppendLine($"{ project.projName}");
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var departments = context.Departments
                .Where(e => e.Employees.Count() > 5)
                .OrderBy(e => e.Employees.Count())
                .ThenBy(e => e.Name)
                .Select(e => new
                {
                    DepartmentName = e.Name,
                    Manager = e.Manager.FirstName + " " + e.Manager.LastName,
                    Employees = e.Employees
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        Job = e.JobTitle
                    })
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToList()
                })
                .ToList();

            foreach (var d in departments)
            {
                sb.AppendLine($"{d.DepartmentName} - {d.Manager}");

                foreach (var employee in d.Employees)
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.Job}");
                }
            }
                

            return sb.ToString().TrimEnd();
        }
        public static string GetLatestProjects(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var projects = context.Projects
                .OrderByDescending(e => e.StartDate)
                .Take(10)
                .OrderBy(e => e.Name)
                .Select(e => new
                {
                    e.Name,
                    e.Description,
                    e.StartDate
                })
                .ToList();


            foreach (var p in projects)
            {
                sb.AppendLine($"{p.Name}\n{p.Description}\n{p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string IncreaseSalaries(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var employees = context.Employees
                .Where(e => e.Department.Name == "Engineering" ||
                e.Department.Name == "Tool Design" ||
                e.Department.Name == "Marketing" ||
                e.Department.Name == "Information Services")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary * (decimal)1.12:f2})");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

