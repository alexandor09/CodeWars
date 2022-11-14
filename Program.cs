using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars    // https://www.codewars.com/kata/52aaf51822e82a808100066b/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = ReplaceAll("SWYN", "", "imtu");
        }
        public static string ReplaceAll(string input, string find, string replace)
        {
            
            if (find == "")  //0-4 5 5-9 
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(input);
                //    stringBuilder.Insert(0 , replace);

                var az = (input.Length + 1) * replace.Length + input.Length;
                for (int i = 0; stringBuilder.Length < az; i++)
                {
                    stringBuilder.Insert(i * replace.Length + i, replace);
                }
                return stringBuilder.ToString();
            }
            var a = input.Replace(find, replace);


            return a;
        }
    }
}
