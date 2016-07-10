using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructData
{
    class GenericStack<T>
    {
        private T[] values = new T[10];
        private int count = 0;

        public void push(T value)
        {
            if (count == values.Length)
                Array.Resize(ref values, count * 2);
            values[count++] = value;
        }

        public T pop()
        {
            if (count == 0)
                throw new IndexOutOfRangeException();
            return values[--count];
        }
    }
}
