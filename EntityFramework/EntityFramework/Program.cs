using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var project = new Projects()
                {
                    Name = "Judge System",
                    StartDate = new DateTime(2015, 4, 15)
                };

                dbContext.Projects.Add(project);
                dbContext.SaveChanges();

                Employees employee = new Employees();
                employee.FirstName = "Thurman";
                employee.LastName = "Murman";

                employee.EmployeesProjects.Add(new Projects { Name = "SoftUni conf" });

/*                var employees = await dbContext.Employees
                    .Where(e => e.Department.Name == "Production")
                    .Select(e => new
                     {
                         Name = $"{e.FirstName} {e.LastName}",
                         Department = e.Department.Name
                     })
                    .ToListAsync();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.Name} {employee.Department}");
                }*/
            }
        }
    }
}
