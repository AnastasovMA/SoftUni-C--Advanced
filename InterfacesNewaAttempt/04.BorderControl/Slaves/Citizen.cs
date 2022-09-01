
namespace _04.BorderControl.Slaves
{
    using _04.BorderControl.Interfaces;
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
    }
}
