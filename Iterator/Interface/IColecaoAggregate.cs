using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IColecaoAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
