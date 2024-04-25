using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortWFv5.Sorting_Algorithms
{
    internal class BubbleSort : Sort
    {
        public BubbleSort(List<int> array) : base(array)
        {
            sortName = "Bubble Sort";
            sortDesc = "Bubble sort repeatedly steps through the list, comparing adjacent elements and swapping them if they are in the wrong order.";
        }
        public override List<int> Run()
        {
            if (SortJ + 1 <= max - SortI)
            {
                if (Compare(SortJ, SortJ + 1) > 0)
                {
                    Swap(SortJ, SortJ + 1);
                    swappedThisCycle = true;
                }

                SortJ++;
            }
            else
            {
                // early exit if no swaps performed on a pass
                if (!swappedThisCycle)
                    SortI = array.Count;

                swappedThisCycle = false;
                SortJ = min;
                SortI++;
            }

            isFinished = SortI > max;

            return array;
        }
    }
}
