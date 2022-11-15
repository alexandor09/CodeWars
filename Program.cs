using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars    // https://www.codewars.com/kata/628df6b29070907ecb3c2d83/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = SpeedAndTime(73, 9);
            Console.WriteLine(res);
        }
        public static int SpeedAndTime(int s, int t)
        {
            int sh = s*(t-1) + s*2;
            
            for (int i = 1; i <= t; i+=2)    
            {
                int distance = FindDistance(s, t, i);    
                
                if (distance > sh)
                    sh = distance;
                
            }
            return sh;
        }
        public static int FindDistance(int s, int t, int a)   // a it is number of change
        {
            int sh = 0;
            int i = 0;
            for (; i < t - a ; i++)
            {
                sh += s;
            }
            while (i < t)
            {
                sh += s * 2;
                s--;
                i++;
                if (i < t)
                {
                    sh += s;
                    i++;
                }
            }
            return sh;
        }


    }
}