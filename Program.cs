using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = MaxSequence(new int[] { -4, -8, 22, 1, -38, 12, 30, -28, 30, 10, -20, 19, 25, -19, -15, 13, -20, 17, 37, -38, -33, 9, 37, -32, 11, -12, -3, -21, 36, -6, -20, 27, -27, 16, -20, -24, 4, -2, -10, 23, -4, 0, -31, -26, 16, 30, 6, 19, -6, 39, 25, -7, -9, 0, -7, -8, -10, 31, -31, 25, -40, -31, 3, -36, -9, -37, -4, 35, -16, 36, 34, 24, 12, -28, 32, -38, -9, -25, 18, 4, 11, 25, -7, -12, -27, 22, 23, -19, 36, -38, -38, -11, -13, -31, -11, 34, -30, -14, 16, 6});
            Console.WriteLine("answer " + a);
            
        }
        public static int MaxSequence(int[] arr)
        {
            int sum = 0;
            int sum2 = 0;            
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum = arr[i];   

                    for (; sum > 0 && i < arr.Length - 1;)
                    {
                        i++;
                        sum += arr[i];
                        if (sum > sum2)
                            sum2 = sum;
                    }                   
                }
            }
            return sum2;
        }

    }
}
