﻿using System;
using System.Collections;
using System.Linq;

namespace DataStructureAndAlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //PairsSumToTarget();
            //MergeTheSortedArrays();
            //TwoSumIndicesProblem();
            //FindMaximumSubArray();
            MoveZeroProblem();



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

        private static void MoveZeroProblem()
        {
            //int[] arr = new int[] { 12, 0, 0, 0, 0, 12 };
            //int[] arr = new int[] { 0, 0, 0, 0, 0, 12 };
            //int[] arr = new int[] { 0, 1, 0, 0, 3, 12 };
            //int[] arr = new int[] {0, 12, 0,0,3,5,0, 1, 0, 3, 12,0 };
            //int[] arr = new int[] { 0, 12, 0, 0, 12, 0 };
            //int[] arr = new int[] { 0, 0 };
            //int[] arr = new int[] { 1, 1 };
            //int[] arr = new int[] { 0, 1 };
            //int[] arr = new int[] { 1, 0 };
            //int[] arr = new int[] { 1 };
            //int[] arr = new int[] { 0 };
            Console.WriteLine("Please provide input");
            string inputs = Console.ReadLine();
            var splittedArray = inputs.Split(',').Select(x => Convert.ToInt32(x.Trim())).ToList();

            MoveZerosProblem oMoveZero = new MoveZerosProblem();
            var Result = oMoveZero.MoveZerosToEnd(splittedArray.ToArray());
        }
    }
}
