using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorAssignment.Model;

namespace IteratorAssignment.Iterators
{
    public class PancakeIterator : IMenuItem
    {
        private List<MenuItem> _items;
        private int _index = 0;

        public PancakeIterator(List<MenuItem> items)
        {
            _items = items;
            
        }

        public bool HasNext()
        {
            if (_index >= _items.Count)
            {
                return false;
            }
            else
                return true;

        }

        public MenuItem Next()
        {
            MenuItem menuItem = _items[_index++];
            return menuItem;
        }
    }
}
