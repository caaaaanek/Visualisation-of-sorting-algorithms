using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWFv5.Sorting_Algorithms
{
    internal class SelectionSort : Sort
    {
        protected int indexOfMin;
        public SelectionSort(List<int> array) : base(array)
        {
            sortName = "Selection Sort";
            sortDesc = "Selection Sort builds a sorted region by means of linear passes to identify the minimum unsorted element.";

            SortI = min;
            indexOfMin = SortI;
            SortJ = indexOfMin + 1;
        }
        public override int getK()
        {
            return indexOfMin;
        }

        public override List<int> Run()
        {
            if (SortJ <= max && SortJ > indexOfMin)
            {
                //finds index of smallest element in array
                if (Compare(SortJ, indexOfMin) < 0)
                    indexOfMin = SortJ;

                SortJ++;
            }
            else if (SortI <= max)
            {
                Swap(SortI, indexOfMin);

                SortI++;
                indexOfMin = SortI;
                SortJ = indexOfMin + 1;
            }

            isFinished = (SortI > max);

            return array;
        }
    }
}
