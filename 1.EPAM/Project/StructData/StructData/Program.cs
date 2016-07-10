using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructData
{
    class Program
    {
        static void Main(string[] args)
        {   
            var stringStack = new StringStack();
            stringStack.push("1");
            stringStack.push("2");
            stringStack.push("3");
            var stringPop = stringStack.pop();
            
            var genericStack = new GenericStack<CustomType>();
            genericStack.push(new CustomType() { Id = 1 });
            genericStack.push(new CustomType() { Id = 2 });
            genericStack.push(new CustomType() { Id = 3 });
            var genericPop = genericStack.pop();
        }

        class CustomType
        {
            public int Id { get; set; }
        }
    }
}
