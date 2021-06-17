using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithmPractice
{
    public class MoveZerosProblem
    {

        public int[] MoveZerosToEnd(int[] inputArray)
        {
            //return MoveZeroToEndInArrayBadApproch(inputArray);            
            return MoveZeroToEndInArrayBestApproch(inputArray);
        }

        private int[] MoveZeroToEndInArrayBadApproch(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Length <= 1)
                    return nums;

                if (nums[i] != 0)
                    continue;

                int current = nums[i];
                int next = 0;
                if ((i + 1) < nums.Length)
                    next = nums[i + 1];

                if (next != 0)
                {
                    nums[i + 1] = current;
                    nums[i] = next;

                    MoveZeroToEndInArrayBadApproch(nums);
                }
            }
            return nums;
        }

        private int[] MoveZeroToEndInArrayBestApproch(int[] nums)
        {

            for (int currentIndex = 0, previousIndex = 0; currentIndex < nums.Length; currentIndex++)
            {
                int currentIndexValue = nums[currentIndex];
                int previousIndexValue = nums[previousIndex];

                if (currentIndexValue == 0)
                {
                    continue;
                }
                else
                {
                    nums[currentIndex] = previousIndexValue;
                    nums[previousIndex] = currentIndexValue;
                    previousIndex++;
                }
            }

            return nums;
        }
    }
}
