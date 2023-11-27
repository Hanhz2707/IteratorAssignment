using IteratorAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAssignment.Iterators
{
    public interface IMenuItem
    {
        bool HasNext();

        MenuItem Next();
        
    }
}
