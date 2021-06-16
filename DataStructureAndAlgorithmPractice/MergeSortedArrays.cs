using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithmPractice
{
    public class MergeSortedArrays
    {/// <summary>
    /// Input : [0,3,4,31] & [4,6,30]
    /// Output : [0,3,4,4,6,30,31]
    /// Ex : [4,2,1,6,3,5]
    /// </summary>
    /// <param name="input1"></param>
    /// <param name="input2"></param>
        public void MergeTheSortedArrays()
        {
            int[] input1 = new int[] { 0, 3, 4, 31,45};
            int[] input2 = new int[]{ 4, 6, 30,32,50 };
            MergeSortedArraysBestSolution(input1, input2);
        }

        private int[] MergeSortedArraysBestSolution(int[] input1, int[] input2)
        {
            int inp1Lenght = input1.Length;
            int inp2Lenght = input2.Length;
            List<int> sortedList = new List<int>();
            bool isInput1ReachedLast = false;
            bool isInput2ReachedLast = false;
            int i = 0;
            int j = 0;

            while (i >= 0 || j >= 0)
            {
                int inpElement1 = input1[i];
                int inpElement2 = input2[j];

                if (inpElement1 < inpElement2)
                {
                    sortedList.Add(inpElement1);
                    if (!((i + 1) > (inp1Lenght - 1)))
                        i++;
                    else
                    {
                        isInput1ReachedLast = true;
                        break;
                    }

                }
                else
                {
                    sortedList.Add(inpElement2);
                    if (!((j+1) > (inp2Lenght-1)))
                        j++;
                    else
                    {
                        isInput2ReachedLast = true;
                        break;
                    }
                }
            }

            if (isInput1ReachedLast)
            {
                while (j < inp2Lenght)
                {
                    int inpElement2 = input2[j];
                    sortedList.Add(inpElement2);
                    j++;
                }
            }
            else if (isInput2ReachedLast)
            {
                while (i < inp1Lenght)
                {
                    int inpElement1 = input1[i];
                    sortedList.Add(inpElement1);
                    i++;
                }
            }

            return sortedList.ToArray();
        }
    }
}
