using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewForm1
{
    public class Product
    {
        public string Name { get; set; }
        public string Specification { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Product() : this("", "", "", 0) { }
        public Product(string name, string specification, string description, double price)
        {
            Name = name;
            Specification = specification;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"Product: {Name}";
        }
    }
}