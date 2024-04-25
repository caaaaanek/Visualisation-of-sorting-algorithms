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
    internal class CocktailShakerSort : Sort
    {
        protected int gap;      // the gap between the elements currently being compared

        public CocktailShakerSort(List<int> array) : base(array)
        {
            this.gap = 1;
            sortName = "Cocktail Shaker Sort";
            sortDesc = "Cocktail Shaker sort performs bubble sort up/down the list in alternation.";
        }

        public override int getI()
        {
            if (gap > 0)
                return SortI;
            else
                return SortJ;
        }

        public override int getJ()
        {
            if (gap > 0)
                return SortJ;
            else
                return SortI;
        }

        public override List<int> Run()
        {
            if (SortJ + gap <= max - SortI && SortJ + gap >= SortI)
            {
                if (Compare(SortJ, SortJ + gap) > 0)
                {
                    Swap(SortJ, SortJ + gap);
                    swappedThisCycle = true;
                }

                SortJ += gap;
            }
            else if (SortI < max)
            {
                if (!swappedThisCycle)
                    SortI = max + 1;

                gap = -gap;
                swappedThisCycle = false;

                if (gap > 0)
                    SortI++;
            }
            else
            {
                isFinished = true;
            }

            return array;
        }
        protected override int Compare(int a, int b)
        {
            // when moving up the list, gap > 0
            // when moving down the list, gap < 0
            // multiplying by gap, ensures the elements are compared correctly
            return base.Compare(a, b) * gap;
        }
    }
}
