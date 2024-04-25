using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortWFv5.Sorting_Algorithms
{
    abstract class Sort
    {
        protected int SortI = 0;  // main pointer
        protected int SortJ = 0;  // secondary pointer
        protected int SortK = 0;  // tertiary pointer

        protected int min = 0;
        protected int max = 0;

        protected bool swappedThisCycle = false;
        protected bool isFinished = false;
        protected bool fillGapWithColour = false;
        
        protected List<int> array;
        public string sortName { get; set; } = "No sort selected";
        public string sortDesc { get; set; } = "";

        public Sort(List<int> array)
        {
            this.array = array;
            setBounds(0, array.Count - 1);
        }
        public virtual void setBounds(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        public bool hasFinished()
        {
            return isFinished;
        }
        public bool isArraySorted()
        {
            // linear pass to determine if array is sorted (so heavy algorithms do not need to be started)

            for (int i = min; i < max; i++)
            {
                if (Compare(i, i + 1) > 0)
                    return false;
            }
            return true;
        }
        public abstract List<int> Run();
        protected virtual void Swap(int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        protected virtual int Compare(int a, int b)
        {
            if (a == b)
                return 0;
            // returns < 0 if array[a] < array[b], 0 if equal, or > 0 if array[a] > array[b]
            return array[a].CompareTo(array[b]);
        }
        public virtual int getI() { return SortI; }
        public virtual int getJ() { return SortJ; }
        public virtual int getK() { return -1; }
    }
}
