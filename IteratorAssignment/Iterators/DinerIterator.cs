using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorAssignment.Model;

namespace IteratorAssignment.Iterators
{
    public class DinerIterator : IMenuItem
    {
        private MenuItem[] _items;
        private int _index = 0;
        public DinerIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (_index >= _items.Length || _items[_index] == null)
            {
            return false;
            }
            else { return true; }

        }
        public MenuItem Next()
        {
            MenuItem item = _items[_index++];
            return item;
        }
            



    }
}
