using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWFv5.Sorting_Algorithms
{
    internal class PatienceSort : Sort
    {
        List<Stack<int>> piles = new List<Stack<int>>();
        List<int> newArr;

        public PatienceSort(List<int> array) : base(array)
        {
            sortName = "Patience Sort";
            sortDesc = "Patience Sorting arranges elements into piles according to their values and then merges these piles into a sorted sequence. It iteratively selects the smallest element from the pile tops until all elements are sorted.";
            newArr = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                newArr.Add(array[i]);
            }
        }

        public override List<int> Run()
        {
            // adds each array element to the piles
            if (SortJ <= max)
            {
                double curr = array[SortJ];

                // find first pile with top card >= current
                foreach (Stack<int> pile in piles)
                {
                    int top = pile.Peek();
                    if (array[top] >= curr)
                    {
                        pile.Push(SortJ);
                        SortJ++;
                        return newArr;
                    }
                }

                // if no pile found, add a new one
                Stack<int> newPile = new Stack<int>();
                newPile.Push(SortJ);
                piles.Add(newPile);
                SortJ++;
            }
            else if (SortI <= max)
            {
                int minPile = 0;
                double minCard = -1;

                // find pile with smallest top card
                for (int i = piles.Count - 1; i > -1; i--)
                {
                    int top = piles[i].Peek();
                    if (minCard == -1 || array[top] < minCard)
                    {
                        minPile = i;
                        minCard = array[top];
                    }
                }

                Stack<int> pile = piles[minPile];

                newArr[SortI] = array[pile.Pop()];

                // delete empty piles
                if (pile.Count == 0)
                    piles.Remove(pile);

                SortI++;
            }
            else
            {
                isFinished = true;
            }

            return newArr;
        }
    }
}
