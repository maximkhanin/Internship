using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(Solution(new int[] { 1, 2, 5, 10, 20, 50, 100, 200 }));
        }

        public static int Solution(int[] coinValues, int target = 200)
        {
            var result = new int[target + 1];
            result[0] = 1;

            for (int i = 0; i < coinValues.Length; i++)
            {
                for (int j = coinValues[i]; j <= target; j++)
                {
                    result[j] += result[j - coinValues[i]];
                }
            }

            return result[target];
        }



    }

}
