using System.Collections;

namespace DataStructureAndAlgorithmPractice
{
    public class PairsSumToTargetProblem
    {
        /// <summary>
        /// Given an array, The program should check if there is any pair which sumup to make a target value.
        /// Eg : [1,2,4,4] TargetSum = 8, Yes it contains a pair [4,4] which sum u to make a 8
        /// </summary>
        /// <returns>Boolean</returns>
        

        public bool PairsSumToTarget()
        {
            int[] firstArray = new int[] { 1, 2, 3, 9 }; // 8
            int[] secondArray = new int[] { 1, 2, 7, 5, 1, 4 }; // 8
            int Sum = 8;

            //return IsAnyPairPresentInTheArrayNaiveApproch(secondArray, Sum); // O(n^2)
            return IsAnyPairPresentInTheArrayBestApprochh(secondArray, Sum); // O(2n)
        }

        private bool IsAnyPairPresentInTheArrayNaiveApproch(int[] sampleArray, int Sum)
        {
            if (sampleArray.Length < 2)
                return false;

            for (int index = 0; index < sampleArray.Length; index++) // O(n)
            {
                int currentElement = sampleArray[index];
                if (currentElement >= Sum)
                    continue;

                for (int j = (index + 1); j < sampleArray.Length; j++) // O(n)
                {
                    int furtherElement = sampleArray[j];

                    if (furtherElement >= Sum)
                        continue;

                    if ((currentElement + furtherElement) == Sum)
                        return true;
                }
            }
            return false;
        }

        private bool IsAnyPairPresentInTheArrayBestApprochh(int[] sampleArray, int Sum)
        {
            if (sampleArray.Length < 2)
                return false;

            Hashtable compliments = new Hashtable();

            for (int complindex = 0; complindex < sampleArray.Length; complindex++)
            {
                int element = sampleArray[complindex];
                int complementValue = (Sum - element);

                if (element >= Sum)
                    continue;
                if (!compliments.ContainsKey(complementValue))
                    compliments.Add(complementValue, true);
            }

            for (int index = 0; index < sampleArray.Length; index++) // O(n)
            {
                if (compliments.ContainsKey(sampleArray[index]))
                    return true;
            }
            return false;
        }
    }
}
