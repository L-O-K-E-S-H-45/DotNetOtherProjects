using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject1ForTest
{
    public class MSTestProblems
    {

        public int FindMaxValue(int[] arr)
        {

            if (arr == null || arr.Length == 0)
                //return -1;
                throw new ArgumentException("Array is empty or null");

            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max )
                    max = arr[i];
            }

            return max;
        }

        public bool StartsWithUpper(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;
            char ch = word[0];
            return char.IsUpper(ch);
        }

    }
}
