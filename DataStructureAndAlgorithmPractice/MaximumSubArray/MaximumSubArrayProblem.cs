using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithmPractice
{
    public class MaximumSubArrayProblem
    {
        public void FindMeximumSubArray(int[] nums)
        {
            int Result =  this.findMaxSumNaiveApproch(nums);

            Console.WriteLine("Maximum Sum found is :" + Result);
            Console.ReadLine();
        }

        private int findMaxSumNaiveApproch(int[] nums)
        {
            int maxSumFound = 0;
            if (nums.Length == 1)
                return nums[0];

            if (nums.Length > 0)
                maxSumFound = nums[0];

            for (int index = 0; index < nums.Length; index++)
            {
                int ielement = nums[index];
                int sum = ielement;

                for (int j = (index + 1); j < nums.Length; j++)
                {
                    int jelement = nums[j];
                    sum += jelement;

                    if (sum > maxSumFound)
                        maxSumFound = sum;
                }

                if (ielement > maxSumFound)
                    maxSumFound = ielement;
            }

            return maxSumFound;
        }

        private int findMaxSumBestApproch(int[] nums)
        {
            int maxSumFound = 0;
            int Sum = 0;
            int i = 0;
            int j = 0;
            if (nums.Length == 1)
                maxSumFound = nums[0];

            while (true)
            {

            }

            return maxSumFound;
        }
    }
}
