using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/55f4e56315a375c1ed000159/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = PowerSumDigTerm(23);
            Console.WriteLine("answer " + a);
        }
        public static long PowerSumDigTerm(int n)
        {
            int result = 4;            
            int sh1 = 0;
            long[] arr = new long[35];
            while (sh1 <= 34)
            {
                for (int i = 2; i < 10; i++)
                {
                    if (IsEq(Math.Pow(result, i)))
                    {
                        Console.WriteLine($"FIND!!! {Math.Pow(result, i)}   {sh1}");
                        arr[sh1] = (long)Math.Pow(result, i);
                        sh1++;
                    }
                }
                Console.WriteLine(result);
                result++;
                
            }
            Array.Sort(arr);
            var resArr = arr.Distinct().ToArray();            
            return resArr[n - 1];
           
        }
        public static bool IsEq (double x)
        {
            var a = x.ToString();
            int res = 0;
            long result = (long)x;
            for (int i = 0; i < Math.Log10(x); i++)
            {
                res += (int)(result - (int)(result / 10) * 10);
                result /= 10;
            }           
            if (res <=1)            
                return false;
            
            result = 1L;

            while (result < x)           
                result *= res;
            
            if (result == x)
                return true;

            return false;
        }
    }
}
