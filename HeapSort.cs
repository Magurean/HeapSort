using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class HeapSort
    {
        private int Size;

        private void Build(int[] v)
        {
            Size = v.Length - 1;
            for (int i = Size / 2; i >= 0; i--)
            {
                Heap(v, i);
            }
        }

        private void Swap(int[] v, int a, int b)
        {
            int temp = v[a];
            v[a] = v[b];
            v[b] = temp;
        }
        private void Heap(int[] v, int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;

            if (left <= Size && v[left] > v[index])
            {
                largest = left;
            }

            if (right <= Size && v[right] > v[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(v, index, largest);
                Heap(v, largest);
            }
        }
        public void Sort(int[] v)
        {
            Build(v);
            for (int i = v.Length - 1; i >= 0; i--)
            {
                Swap(v, 0, i);
                Size--;
                Heap(v, 0);
            }
            Print(v);
        }
        private void Print(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
             Console.Write("{0} ", v[i]); 
        }
    }
}
