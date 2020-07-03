using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №8

            decimal a = 123456789;
            decimal result;

        Start:

            Console.WriteLine("Введите любое число (9, 18, 27 ... 81):");

            Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");

            string input = Console.ReadLine();
            int number = int.Parse(input);


            if (number == 9)
            {
                result = a * 9;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 18)
            {
                result = a * 18;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 27)
            {
                result = a * 27;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 36)
            {
                result = a * 36;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 45)
            {
                result = a * 45;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }

            else if (number == 54)
            {
                result = a * 54;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 63)
            {
                result = a * 63;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 72)
            {
                result = a * 72;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto Start;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 81)
            {
                result = a * 81;
                Console.WriteLine(result);
                Console.WriteLine("Хотите попробовать ещё раз? 1 - Да / 2 - Нет");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
            else if (number == 1)
            {
                Console.Clear();
                goto NextTaskOne;
            }
            else
            {
               Console.WriteLine("Введите число: 9, 18, 27, 36, 45, 54, 63, 72 или 81");
                goto Start;
            }


        NextTaskOne:
            {
                // Задание №24

                double x = 2;

                while (x < 2.8)
                {
                    x = x + 0.1;
                    Console.WriteLine(x);
                }
                Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto NextTaskTwo;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }


        NextTaskTwo:
            {
                // Задание №17

                int v;

                string inputN = Console.ReadLine();
                int n = int.Parse(inputN);

                for (v = 1; v < 10; v++)
                {
                    Console.WriteLine(n + "*" + v + "=" + n * v);
                }

                Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto NextTaskThree;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }


        NextTaskThree:
            {

                // Задание №15

                int v;
                int n = 7;


                for (v = 1; v < 10; v++)
                {
                    Console.WriteLine(n + "*" + v + "=" + n * v);
                }

                Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto NextTaskFour;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }

        NextTaskFour:
            {
                // Задание №16

                int v;
                int n = 9;

                for (v = 1; v < 10; v++)
                {
                    Console.WriteLine(n + "*" + v + "=" + n * v);
                }

                Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto NextTaskFive;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }

        NextTaskFive:
            {
                // Задание №21

                for (float i = 0.1f; i <= 1; i += 0.1f)
                {
                    Console.WriteLine(i + " sin");
                }
                Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto NextTaskSix;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
        NextTaskSix:
            {
                // Задание №9

                float price = 20.4f;
                float res;
                int i;

                for (i = 2; i <= 21; i++)
                {
                    res = price * i;
                    Console.WriteLine("price - " + res);
                }
                Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto NextTaskSeven;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }
        NextTaskSeven:
            {
                // Задание №2

                Console.WriteLine("Введите число");

                string xInput = Console.ReadLine();
                int x = int.Parse(xInput);

                for (int I = 1; I < x; I++)
                {
                    if (x % I == 0)
                    {
                        Console.WriteLine(I);
                    }
                }
                Console.WriteLine("Если хотите перейти к следующему заданию введите: 1");
                string YesNo = Console.ReadLine();
                int YesOrNo = int.Parse(YesNo);

                if (YesOrNo == 1)
                {
                    Console.Clear();
                    goto NextTaskEight;
                }
                if (YesOrNo == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пока)");
                }
            }

        NextTaskEight:
            {
                // Задание №94

                double massSred = 0;

                Console.WriteLine("Введите массу");

                string Ninput = Console.ReadLine();
                int n = int.Parse(Ninput);

                for (int i = 0; i < n; i++)
                {
                    massSred += i;
                }

                Console.WriteLine(massSred /= 10);
            }
        }
    }
}
        
  
