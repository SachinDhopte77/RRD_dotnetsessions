using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Models
{
    // Aggregate Interface
    internal interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
