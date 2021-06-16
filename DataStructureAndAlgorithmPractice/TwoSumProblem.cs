using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithmPractice
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// Input: nums = [2,7,11,15], target = 9
    /// Output: [0,1]
    /// Output: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </summary>
    public class TwoSumProblem
    {

        public int[] GetTargetSumIndices()
        {
            int[] nums = new int[]{ 2, 4, 4, 7, 11, 15 };
            List<int> compliments = new List<int>();
            int target = 50;
            int[] sumIndices = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int element = nums[i];
                int complement = target - element;
                
                if (!compliments.Contains(element))
                {
                    if (!compliments.Contains(complement))
                        compliments.Add(complement);
                }                    
                else
                {
                    sumIndices[0] = compliments.FindIndex(x => x == element);
                    sumIndices[1] = i;
                    break;
                }
            }
            return sumIndices;
        }
    }
}
