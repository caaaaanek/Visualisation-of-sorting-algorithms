using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWFv5.Sorting_Algorithms
{
    internal class ShellSort : Sort
    {
        private int gap;

        public ShellSort(List<int> array) : base(array)
        {
            sortName = "Shell Sort";
            sortDesc = "Shell Sort performs insertion sorts with a decreasing gap between compared elements.";
            
            fillGapWithColour = true;
            gap = 1;
            while (gap <= max / 2)
            {
                gap = CalculateGap();
            }
        }
        public override List<int> Run()
        {
            if (SortJ - gap >= min && SortJ <= max)
            {
                if (Compare(SortJ, SortJ - gap) < 0)
                    Swap(SortJ, SortJ - gap);
                else
                {
                    SortI += 1;
                    SortJ = SortI + gap;
                }
                SortJ -= gap;
            }
            else if (SortI <= max)
            {
                SortI += 1;
                SortJ = SortI;
            }
            else if (gap > 1)
            {
                gap = CalculateGap();
                SortI = min + gap;
                SortJ = SortI;
            }
            else
            {
                isFinished = true;
            }

            return array;
        }

        private int CalculateGap()
        {
            // Hibbard intervals
            return (gap + 1) * 2 + 1;
        }
    }
}
