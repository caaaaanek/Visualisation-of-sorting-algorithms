using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWFv5.Sorting_Algorithms
{
    internal class InsertionSort : Sort
    {
        public InsertionSort(List<int> array) : base(array)
        {
            sortName = "Insertion Sort";
            sortDesc = "Insertion Sort builds a sorted region by swapping each element backwards until it is in the correct position in the sorted region.";
        }
        public override void setBounds(int min, int max)
        {
            base.setBounds(min, max);
            SortI = min + 1;
            SortJ = SortI;
        }

        public override int getJ()
        {
            return SortJ;
        }

        public override List<int> Run()
        {
            if (SortJ > min && SortJ <= max && Compare(SortJ - 1, SortJ) > 0)
            {
                Swap(SortJ - 1, SortJ);
                SortJ -= 1;
            }
            else if (++SortI <= max)
            {
                SortJ = SortI;
            }
            else
                isFinished = true;

            return array;
        }
    }
}
