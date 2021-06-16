using System;
using System.Collections;

namespace DataStructureAndAlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //PairsSumToTarget();
            //MergeTheSortedArrays();
            //TwoSumIndicesProblem();
            FindMaximumSubArray();




        }
        
        private static void PairsSumToTarget()
        {
            PairsSumToTargetProblem opairSumProblem = new PairsSumToTargetProblem();
            bool Result = opairSumProblem.PairsSumToTarget();            
            Console.WriteLine("Is Any Pair present in the Array : " + Result);
            Console.ReadLine();
        }
        private static void MergeTheSortedArrays()
        {

            MergeSortedArrays omerge = new MergeSortedArrays();
            omerge.MergeTheSortedArrays();
        }
        private static void TwoSumIndicesProblem()
        {
            TwoSumProblem oTwoSum = new TwoSumProblem();
            oTwoSum.GetTargetSumIndices();
        }

        private static void FindMaximumSubArray()
        {
            //int[] arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int[] arr = new int[] { -1, 2};
            //int[] arr = new int[] {-1,2,-2, -150 };
            int[] arr = new int[] {-2, -1};
            MaximumSubArrayProblem omaxsubarray = new MaximumSubArrayProblem();
            omaxsubarray.FindMeximumSubArray(arr);
        }
    }
}
