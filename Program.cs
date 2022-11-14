using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = CountPairsInt(1, 50);



        }
        public static int CountPairsInt(int diff, long nMax)
        {
            var a = DoArrayOfSimpleNumbers(nMax);
            var b = ReformArray(a);
            int finalSh = 0;
            nMax = b.Last() - diff;

            for (int i = 2; i < nMax; i++)
            {
                int one = HowMuchdivisors(i, b);
                int two = HowMuchdivisors(i + diff, b);
                if (one == two)
                {
                    Console.WriteLine($"Same par number {finalSh + 1}  :  {i}  and  {i+diff}");
                    finalSh++;
                }

                    
            }

            return finalSh;
        }
        static public long [] ReformArray(long [][] array)
        {
            int length0 = array.Length;
            int length1 = array[0].Length;
            int shofNoElem = 0;
            int shofArrayElem = 0;
            for (int i = 0; i < 10; i++)
            {
                if (array[array.Length - 1][i] == 0)
                    shofNoElem++;                
            }
            long[] arrayResult = new long[length0 * length1 - shofNoElem];  

            for (int i = 0; i < length0 - 1; i++)
            {
                for (int j = 0; j < length1; j++)
                {
                    arrayResult[shofArrayElem] = array[i][j];
                    shofArrayElem++;
                }
            }
            for (int i = 0; i < 10 -shofNoElem; i++)
            {
                arrayResult[shofArrayElem] = array[length0 - 1][i];
                shofArrayElem++;
            }
            return arrayResult;
        }



        static public int HowMuchdivisors(long a , long[] arrayOfSimpleNumber)
        {
            int resultDivisions = 1;
            long aa = a;
            for (int i = 0; arrayOfSimpleNumber[i] <= aa; i++)
            {
                while (true)
                {
                    while (a % arrayOfSimpleNumber[i] == 0)
                    {
                        a /= arrayOfSimpleNumber[i];
                        resultDivisions++;
                    }                  

                }
            }
            return resultDivisions;
        }

        static public long [][] DoArrayOfSimpleNumbers(long a)
        {
            List<long[]> list = new List<long[]>();
            list.Add(new long[10]);
            list[0][0] = 2;
            double range = Math.Sqrt(a) + 1;
            bool flag = false;
            int index0 = 0, index1 = 1;
            int sh = 1;

            for (int k = 3; k < a; k+=2)
            {
                index0 = 0; index1 = 0;
                var z = Math.Sqrt(k) + 1;
                for (int i = 3; i < list.Count * list[0].Length ; i = i + 2)
                {
                    if (list[index0][index1] == 0)
                        break;
                    if (k % list[index0][index1] == 0 )
                    {
                        flag = true;
                        break;
                    }
                        
                    index1++;
                    if (index1 >= 10)
                    {
                        index1 = 0;
                        index0++;                        
                    }
                }
                if (!flag)
                {
                    list[list.Count - 1][sh] = k;
                    sh++;
                }
                flag = false;

                if (sh == list[0].Length && index0 == list.Count - 1)
                {
                    list.Add(new long[10]);
                    sh = 0;
                }
                    

                

            }
            return list.ToArray();
        }
       

    }
}
