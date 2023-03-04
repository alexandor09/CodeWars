using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Gourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start_i = 6;    // стартовая точка по высоте
            int start_j = 6;    // стартова точка по ширине
            int fin_i = 7;      // финишная точка по высоте
            int fin_j = 7;      // финишная точка по ширине

            while ((Math.Abs(start_i + start_j - fin_i - fin_j) >= 3)) // пока расстояние больше 3, то подходить
            {
                Podshag(ref start_i, ref start_j, fin_i, fin_j);
            }

            if (Win_or_Loos(start_i, start_j, fin_i, fin_j) || (start_i == fin_i && start_j == fin_j))
            {
                Console.WriteLine("You win!!");
                return;
            }

            if ((Math.Abs(start_i - fin_i) + (Math.Abs(start_j - fin_j)) == 2))
            {
                if (start_i == fin_i || start_j == fin_j)
                    Rasstoianie_2_Vbok(ref start_i, ref start_j, fin_i, fin_j);
                else
                    Diagonal(ref start_i, ref start_j, fin_i, fin_j);
            }
            if ((Math.Abs(start_i - fin_i) + (Math.Abs(start_j - fin_j)) == 1))
            {
                Rasstoianie_1(ref start_i, ref start_j, fin_i, fin_j);
            }

        }

        public static void Podshag(ref int start_i, ref int start_j, int fin_i, int fin_j)  // подходим до тех пор, пока расстояние не будет равно менее 3
        {
            if (Math.Abs(start_i - fin_i) > Math.Abs(start_j - fin_j)) // по i больше
            {
                start_i = start_i > fin_i ? start_i - 2 : start_i + 2;
                start_j = start_j > fin_j ? start_j - 1 : start_j + 1;
            }
            else  // по j больше
            {
                start_i = start_i > fin_i ? start_i - 1 : start_i + 1;
                start_j = start_j > fin_j ? start_j - 2 : start_j + 2;
            }
        }
        public static void Diagonal(ref int start_i, ref int start_j, int fin_i, int fin_j)  // в худшем случае
                                                                                             // на 6 ход мы придём к финишу
        {
            start_i = fin_i;
            if (fin_j > 4)      // если он больше 4, то ход в другую сторону           
                start_j = start_j - 2;

            else
                start_j = start_j + 2;    // первый ход

            if (Math.Abs(start_i + start_j - fin_i - fin_j) == 1)
            {
                Rasstoianie_1(ref start_i, ref start_j, fin_i, fin_j);
                Console.WriteLine("You Win!!!");
                return;
            }

            start_i = start_i > 5 ? start_i - 2 : start_i + 2;
            start_j = start_j > 6 ? start_j - 1 : start_j + 1;   // второй ход

            start_i = start_i > 5 ? start_i - 1 : start_i + 1;
            start_j = fin_j;                                        // третий ход

            if (Math.Abs(start_i + start_j - fin_i - fin_j) == 1)
            {
                Rasstoianie_1(ref start_i, ref start_j, fin_i, fin_j);
                Console.WriteLine("You Win!!!");
                return;
            }
        }
        public static void Rasstoianie_1(ref int start_i, ref int start_j, int fin_i, int fin_j)   // расстояние между точками равно одному (лежат на одной прямой)
        {

            int vrem_i = start_j == fin_j ? fin_i : start_i + 2;
            if (Math.Abs(vrem_i - fin_i) > 2)
                vrem_i = -4;
            int vrem_j = start_i == fin_i ? fin_j : start_j + 2;
            if (Math.Abs(vrem_j - fin_j) > 0)
                vrem_j -= 4;          // четвертый ход
            start_i = vrem_i; start_j = vrem_j;             // временные переменные, созданные для сравнения без ошибок   
            Rasstoianie_2_Vbok(ref start_i, ref start_j, fin_i, fin_j);
        }

        public static void Rasstoianie_2_Vbok(ref int start_i, ref int start_j, int fin_i, int fin_j)  // точки находятся на одной плоскости на расстоянии = 2
        {
            if (start_i == fin_i)
            {
                start_i = start_i + 2 > 7 ? start_i - 2 : start_i + 2;
            }
            else
            {
                start_i = start_i > fin_i ? start_i - 1 : start_i + 1;
            }
            if (start_j == fin_j)
            {
                start_j = start_j + 2 > 7 ? start_j - 2 : start_j + 2;
            }
            else
            {
                start_j = start_j > fin_j ? start_j - 1 : start_j + 1;
            } // был сделан 5 ход, далее идет проверка

            if (Win_or_Loos(start_i, start_j, fin_i, fin_j))  // проверка на правильность
            {
                Console.WriteLine("You win!");
                start_i = fin_i;
                start_j = fin_j;
            }
            else
                Console.WriteLine("ERROR!");  // для неудачной проверки
        }
        public static bool Win_or_Loos(int start_i, int start_j, int fin_i, int fin_j)
        {
            return (Math.Abs(start_i - fin_i) + Math.Abs(start_j - fin_j) == 3 && start_i != fin_i && start_j != fin_j);
        }
    }
}
