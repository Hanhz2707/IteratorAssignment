using IteratorAssignment.Iterators;
using IteratorAssignment.Menu;
using IteratorAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAssignment.Waiters
{
    public class Waiter
    {
        private IMenu _pancakeMenu;
        private IMenu _dinerMenu;

        public Waiter(IMenu pancakeMenu, IMenu dinerMenu)
        {
            _pancakeMenu = pancakeMenu;
            _dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            
            IMenuItem pancakeIterator = _pancakeMenu.createIterator();
            IMenuItem dinerIterator = _dinerMenu.createIterator();

           
            Console.WriteLine("\n BREAKFAST's MENU ");
            iterate(pancakeIterator);

           
            Console.WriteLine("\n DINER's MENU ");
            iterate(dinerIterator);
        }

        private void iterate(IMenuItem iter)
        {
            
            while (iter.HasNext())
            {
                
                MenuItem item = iter.Next();
                Console.WriteLine($"{item.Name}, {item.Description}. Price: {item.Price}. " +
                    $"{(item.IsVegetarian ? "v" : "")}");
            }
        }
    }
}
