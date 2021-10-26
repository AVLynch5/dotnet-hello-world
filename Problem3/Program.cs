using System;

namespace Problem3
{
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {
            int totalSum = 0;
            foreach (int i in arr)
            {
                if (i >= 0)
                {
                    totalSum += i;
                }
            }
            return totalSum;
        }
    }


}
