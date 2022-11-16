using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars    // https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Solution(20);
            Console.WriteLine(res + "*");
        }
        public static int Solution(int value)
        {
            if (value <= 0)
                return 0;

            int sh = 0;
            for (int i = 1; i * 3 < value; i++)            
                sh += i * 3;
            
            for (int i = 1; i * 5 < value; i++)
            {
                if (i % 3 == 0)
                    continue;

                sh += i * 5;
            }
            return sh;
        }
    }
}
