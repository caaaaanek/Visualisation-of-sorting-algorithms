using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortWFv5.Sorting_Algorithms
{
    internal class DoubleSelectionSort : SelectionSort
    {
        private int indexOfMax;

        public DoubleSelectionSort(List<int> array) : base(array)
        {
            sortName = "Double Selection Sort";
            sortDesc = "Double Selection performs a Selection Sort, but selects both the minimum and maximum element in each pass.";
            // complexity remains same as default selection sort

            indexOfMax = max - SortI - 1;
        }

        public override List<int> Run()
        {
            if (SortJ < array.Count - SortI)
            {
                //finds minimum value
                if (Compare(SortJ, indexOfMin) < 0)
                    indexOfMin = SortJ;
                // finds maximum value
                if (Compare(max - SortJ, indexOfMax) > 0)
                    indexOfMax = array.Count - SortJ - 1;

                SortJ++;
            }
            else
            {
                int firstSwapPos = SortI;
                int secondSwapPos = max - SortI;

                if (indexOfMin != indexOfMax)
                {
                    Swap(firstSwapPos, indexOfMin);

                    // if the maximum is moved by the first swap, then we know what index it is
                    if (indexOfMax == firstSwapPos)
                        indexOfMax = indexOfMin;

                    Swap(secondSwapPos, indexOfMax);
                }
                else
                {
                    // min and max need to be swapped
                    Swap(indexOfMin, indexOfMax);
                }

                SortI++;
                indexOfMin = SortI;
                indexOfMax = max - SortI;
                SortJ = indexOfMin + 1;
            }

            isFinished = SortI > max / 2;

            return array;
        }
    }
}
