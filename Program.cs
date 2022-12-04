using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/561e9c843a2ef5a40c0000a4/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Gap(10, 1301, 1401);
            Console.WriteLine("answer " + a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            
        }
        public static long[] Gap(int g, long m, long n)
        {          
            if (m % 2 == 0)
                m++;

            while (m + g <= n)
            {    
                if (IsSimple(m) && IsSimple(m + g))
                {
                    if (g == 2)
                        return new long[] { m, (m + g) };
                   

                    for (int i = 2; i < g; i+=2)
                    {
                        if (IsSimple(m + i))
                           break;
                       
                        else if (i + 2 == g)
                            return new long[] { m, (m + g) };
                    }
                }
                m+=2;
            }
            return null;
        }

        public static bool IsSimple(long n)
        {
            double length = Math.Sqrt((double)n) + 1;
            for (int i = 3; i < length; i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
