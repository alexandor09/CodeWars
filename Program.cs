using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/57bf7fae3b3164dcac000352/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = FindPrimeSextuplet(600);
            Console.WriteLine("answer " + a);
            
        }
        public static int[] FindPrimeSextuplet(int sumLimit)
        {
            int start = sumLimit / 6 - 8;
            int[] arr = new int[6];
            int sh = 0;

            if (start % 2 == 0)
                start++;

            for (int i = start; i < int.MaxValue; i+=2)
            {
                if (FindSImple(i))
                {                    
                    arr[sh] = i;                    
                    if (sh % 2 == 0)                    
                        i += 2;
                   
                    sh++;

                    if (arr[5] != 0)                    
                        return arr;

                    continue;
                }
                if (sh != 0)
                {
                    sh = 0;
                    i = arr[sh];
                }
            }
            return arr;  
        }

        public static bool FindSImple(int sumLimit)
        {
            int length = (int)Math.Sqrt(sumLimit) + 1;

            for (int i = 3; i < length; i+=2)
            {
                if (sumLimit % i == 0)
                {
                    return false;
                }                
            }
            return true;
        }

    }
}
