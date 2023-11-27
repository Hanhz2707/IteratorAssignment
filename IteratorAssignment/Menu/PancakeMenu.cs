using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorAssignment.Iterators;
using IteratorAssignment.Model;

namespace IteratorAssignment.Menu
{
    public class PancakeMenu : IMenu
    {
       
        private List<MenuItem> _menuItems = new List<MenuItem>();

        public PancakeMenu()
        {
            addItem(new MenuItem("K&B’s Pancake Breakfast", " -- Pancakes with scrambled eggs, and toast", 2.99, false));
            addItem(new MenuItem("Regular Pancake Breakfast", " -- Pancakes with fried eggs, sausage", 2.99, false));
            addItem(new MenuItem("Blueberry Pancakes", " -- Pancakes made with fresh blueberries", 3.49, false));
            addItem(new MenuItem("Waffles", " -- Waffles, with your choice of blueberries or strawberries", 3.59, false));
        }

        public void addItem(MenuItem item)
        {
            _menuItems.Add(item);
        }

        public IMenuItem createIterator()
        {
            return new PancakeIterator(_menuItems);
        }
    }
}
