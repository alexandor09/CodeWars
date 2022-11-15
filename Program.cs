using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars    // https://www.codewars.com/kata/587731fda577b3d1b0001196/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = CamelCase(" camel case word");
            Console.WriteLine(res + "*");
        }
        public static string CamelCase(string str)
        {
            if (str.Length == 0)
                return str;
            
            StringBuilder stringBuilder = new StringBuilder();
           
            bool ToUp = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    ToUp = true;
                    continue;                    
                }
                if (ToUp)
                {
                    stringBuilder.Append(Char.ToUpper(str[i]));
                    ToUp = false;
                    continue;
                }   
                stringBuilder.Append(str[i]);
            }
            stringBuilder[0] = Char.ToUpper( stringBuilder[0]);
            return stringBuilder.ToString();
        }
    }
}
