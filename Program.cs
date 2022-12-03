using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars    // https://www.codewars.com/kata/5541f58a944b85ce6d00006a/train/csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = productFib(4895);
            Console.WriteLine("answer " + a);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static ulong[] productFib(ulong prod)
        {
            ulong n1 = 0;
            ulong n2 = 1;
            while (n1 * n2 < prod)
            {
                ulong temp = n2;
                n2 += n1;   
                n1 = temp;
            }

            ulong[] arr = new ulong[] { n1, n2, 0 };

            if (n1 * n2 == prod)            
                arr[2] = 1;        
            
            return arr;
        }        
    }
}
