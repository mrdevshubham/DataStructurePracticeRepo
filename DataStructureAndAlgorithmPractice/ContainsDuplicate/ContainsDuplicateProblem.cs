using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgorithmPractice
{
    public class ContainsDuplicateProblem
    {
        public bool ContainsDuplicateElements(int[] nums)
        {
            //var Result = FindDuplicateElementsApprochOne(nums);
            //if (Result.Count > 0)
            //    return true;
            //return false;            

            //var Result = FindDuplicateElementsApprochTwo(nums);

            //if (Result.Values.OfType<int>().Count(x => x > 1) > 0)
            //    return true;
            //return false;

            return nums.Distinct().Count() < nums.Length ? true : false; // Another approch

        }

        private Hashtable FindDuplicateElementsApprochOne(int[] nums)
        {
            Hashtable duplicateElements = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = (i+1); j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        if (duplicateElements.ContainsKey(nums[i]))
                        {
                            int value = (int)duplicateElements[nums[i]];
                            duplicateElements[nums[i]] = value + 1;
                            
                        }
                        else
                            duplicateElements.Add(nums[i], 1);
                    }
                }
            }

            return duplicateElements;
        } // Not very Good Approch

        private Hashtable FindDuplicateElementsApprochTwo(int[] nums) // Bettwe approch then approch One
        {
            Hashtable uniqueElements = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueElements.ContainsKey(nums[i]))
                {
                    int value = (int)uniqueElements[nums[i]];
                    uniqueElements[nums[i]] = value + 1;
                }
                else
                    uniqueElements.Add(nums[i],1);
            }

            return uniqueElements;
        }

        private bool ContainsDuplicateElementsThree(int[] nums) // Better than Second Approch
        {
            HashSet<int> dupes = new HashSet<int>();
            foreach (int i in nums)
            {
                if (dupes.Contains(i))
                {
                    return true;
                }
                dupes.Add(i);
            }
            return false;
        }
    }
}
