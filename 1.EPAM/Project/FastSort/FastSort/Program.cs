using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FastSort
{
    class Program
    {
        private static  int count1;
        static void Main(string[] args)
        {
            Boolean TerminateIteration = false;
            while (TerminateIteration != true)
            {
                Console.WriteLine("Continue iteration? [yes] [no]:");
                string answer = Console.ReadLine();
                if (answer == "no") { break; }
                    
                Console.WriteLine("Write an array separated by commas:");            
                string arr = Console.ReadLine();            
                string[] st = arr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int size = st.Length;
                int[] array = new int[size];
                for (int i = 0; i < size; i++)//Convert Array
                {
                    array[i] = Convert.ToInt32(st[i]);
                }
                var watch = Stopwatch.StartNew();//measure time
                int[] array2 = quicksort(array, 0, array.Length - 1);
                watch.Stop();             
                var elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine("ElapsedTime {0}", elapsedMs);
                PrintArray(array2);
                Console.ReadLine();
            }
         }

        static int partition(int[] array, int start, int end)
        {
            int markEl = start;//pivot element
            for (int i = start; i <= end; i++)//loop elements
            {
                if (array[i] <= array[end])
                {
                    int temp = array[markEl];//take element
                    array[markEl] = array[i];
                    array[i] = temp;
                    markEl += 1;//next element
                }
            }
            return markEl - 1; //return new number pivotEl
        }

        static int[] quicksort(int[] array, int start, int end)
        {            
            if (start >= end)
            {
                return array;
            }                    
                     
            int pivot = partition(array, start, end);                 
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
            return array;
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);            
        }

    }
}
