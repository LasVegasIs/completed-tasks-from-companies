using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructData
{
    class StringStack
    {
        private string[] values = new string[10];
        private int count = 0;

        public void push(string value)
        {
            if (count == values.Length)
                Array.Resize(ref values, count * 2);//Increasing the size of the array
            values[count++] = value;
        }
        public string pop()
        {
            if (count == 0)
                throw new IndexOutOfRangeException();//Create exception
            return values[--count];
        }

    }
}
