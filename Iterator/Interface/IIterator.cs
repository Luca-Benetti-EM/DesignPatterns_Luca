using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IIterator<T>
    {
        void first();
        void next();
        bool isDone();
        T currentItem();
    }
}
