using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/576b072359b1161a7b000a17/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = GenerateDiagonal(3, 7);           
        }
        public static BigInteger[] GenerateDiagonal(int n, int l)
        {
            BigInteger[] result = new BigInteger[l];

            for (int i = 0; i < l; i++)
            {
                var a = Factorial(i, n + i);               
                result[i] = a.Item3/(a.Item2*a.Item1);
            }

            return result;
        }
        public static (BigInteger, BigInteger , BigInteger) Factorial (int n, int k)
        {
            BigInteger bigInteger = new BigInteger();
            BigInteger bigInteger2 = new BigInteger();
            BigInteger bigInteger3 = new BigInteger();
            bigInteger = 1;
            bigInteger2 = 1;
            int i = 1;
            if (n > k - n)
            {
                for (; i <= k - n; i++)                
                    bigInteger2 *= i;
                
                bigInteger = bigInteger2;
            }
            
            for (; i <= n; i++)            
                bigInteger *= i;
            
            if (n <= k - n)
            {
                bigInteger2 = bigInteger;
                for (; i <= k - n; i++)
                {
                    bigInteger2 *= i;
                }
                bigInteger3 = bigInteger2;
            }

            else            
                bigInteger3 = bigInteger;
                      

            for (; i <= k; i++)            
                bigInteger3 *= i;
            
            return (bigInteger , bigInteger2 , bigInteger3);
        }
    }
}
