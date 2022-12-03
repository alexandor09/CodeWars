using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/52774a314c2333f0a7000688/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = ValidParentheses("()");
            Console.WriteLine("answer " + a);
            
        }
        public static bool ValidParentheses(string input)
        {            
            int n = 0;
            foreach (var item in input)
            {
                if (n < 0)               
                    return false;
               
                if (item == '(')                
                    n++;
                
                if (item == ')')                
                    n--; 
            }

            if (n == 0)
                return true;

            return false;
        }
    }
}
