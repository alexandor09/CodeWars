using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/526dbd6c8c0eb53254000110/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Alphanumeric("Mazinkaiser");
            Console.WriteLine(a);
        }

        public static bool Alphanumeric(string str)
        {
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (IsCharOrDec(str[i]))
                {
                    continue;
                }              
                return false;
            }
            return true;
        }

        static Predicate<char> IsCharOrDec = (char a) =>
        {
            int b = a;

            if (b > 64 && b < 123)  // IsChar
            {
                if (b > 90 && b < 97)
                {
                    return false;
                }
                return true;
            }

            if (b > 47 && b < 58)  // is Numeric
                return true;
            
            return false;
        };

    }
}
