using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IteratorAssignment.Model
{
    public class MenuItem
    {
        public MenuItem(string name, string description, double price, bool isVege)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVege;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsVegetarian { get; set; }
    }
}