using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = GetReadableTime(359999);
            Console.WriteLine("answer " + a);
        }
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 359999)            
                return "99:59:59";

            if (seconds >= 86400)
            {
                int day = seconds / 86400;
                seconds -= day * 86400;

                var b = TimeSpan.FromSeconds(seconds);
                var str = b.ToString();
                int hour = int.Parse(str.Substring(0, 2)) + 24 * day;
                str = hour.ToString() + str.Substring(2,str.Length-2);
                return str;
            }
            var c = TimeSpan.FromSeconds(seconds);
            return c.ToString();
        }
    }
}
