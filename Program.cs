using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 54, 31, 5, 79, 1, 21, 22, 19, 66, 31 };
            HeapSort heap = new HeapSort();
            heap.Sort(v);

            Console.ReadLine();
        }
    }
}
