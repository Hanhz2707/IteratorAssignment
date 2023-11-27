using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorAssignment.Iterators;
using IteratorAssignment.Model;

namespace IteratorAssignment.Menu
{
    public class DinerMenu : IMenu
    {
        
        private int _itemIndex = 0;
        private const int MaxItems = 5;
        private MenuItem[] _menuItems = new MenuItem[MaxItems];

        public DinerMenu()
        {
            addItem(new MenuItem("Vegetarian BLT", " -- (Fakin’) Bacon with lettuce & tomato on whole wheat", 2.99, false));
            addItem(new MenuItem("BLT", " -- Bacon with lettuce & tomato on whole wheat", 2.99, false));
            addItem(new MenuItem("Soup of the day", " -- Soup of the day, with a side of potato salad", 3.29, false));
            addItem(new MenuItem("Hotdog", " -- A hot dog, with saurkraut, relish, onions, topped with cheese", 3.05, false));
        }

        // Add menu item, if the menu still has vacant slot
        public void addItem(MenuItem item)
        {
            if (_itemIndex >= MaxItems)
            {
                Console.WriteLine("Sorry, no more slots in menu");
                return;
            }
            else
            {
                _menuItems[_itemIndex] = item;
                _itemIndex++;
            }
        }

        public IMenuItem createIterator()
        {
            return new DinerIterator(_menuItems);
        }
    }
}
