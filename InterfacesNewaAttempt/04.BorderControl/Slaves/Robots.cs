
namespace _04.BorderControl.Slaves
{
    using _04.BorderControl.Interfaces;
    public class Robots : IIdentifiable
    {
        public Robots(string model, int id)
        {
            Model = model;
            Id = id;
        }
        public int Id { get; set; }
        public string Model { get; set; }
    }
}
