using System;
using System.Linq;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/5503013e34137eeeaa001648/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = print(5);           
        }
        public static string print(int n)
        {
            if (n < 1 || n%2 == 0)
            {
                return null;
            }
            int heigth = n / 2 + 1;

            StringBuilder stringBuilder = new StringBuilder();
            int i = 0;
            int sh = 1;
            for (int a = 0; a < 2; a++)
            {
                while ( i < heigth && i > -1)
                {
                    stringBuilder.Append(String.Concat(Enumerable.Repeat(" ", heigth - i - 1)));
                    stringBuilder.Append(String.Concat(Enumerable.Repeat("*", i * 2 + 1)));
                    stringBuilder.Append("\n");
                    i += sh;
                }
                i -= 2;
                sh = -1;
            }   

            return stringBuilder.ToString();            
        }
    }
}
