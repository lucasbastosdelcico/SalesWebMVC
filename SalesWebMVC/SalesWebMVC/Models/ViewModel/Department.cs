using System.Globalization;

namespace SalesWebMVC.Models.ViewModel
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}
