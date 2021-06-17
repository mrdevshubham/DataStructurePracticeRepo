using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureAndAlgorithmPractice
{
    public class RotateArrayByK
    {

        public int[] RotateArrayBykFromLast(int[] arr, int k)
        {
            var Result = RotateArrayApprochOne(arr, k);
            return Result;
        }


        private int[] RotateArrayApprochOne(int[] nums, int k)
        {

            if (k > nums.Length)   // [1,2,3] if k = 7, then rotate 1 from last, k=8 rotate 2 from last and so on
                k = k % nums.Length;

            if (k > 0)
            {
                int[] newElements = new int[k];

                int n = 0;
                for (int index = (nums.Length - k); index < nums.Length; index++)
                {
                    newElements[n] = nums[index];
                    nums[index] = 0;
                    n++;
                }

                int i = (nums.Length - k - 1);
                int j = (nums.Length - 1);

                while (i >= 0 && j >= k)
                {
                    nums[j] = nums[i];
                    nums[i] = 0;
                    i--;
                    j--;
                }

                for (int y = 0; y < newElements.Length; y++)
                {
                    nums[y] = newElements[y];
                }
            }            
            return nums;
        }


    }
}
