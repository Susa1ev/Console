using System;

namespace prac3._3_c_
{
    class prac
    {
        public prac()
        {
            Main();
        }
        int a, b, h;
        double y;
        double f(double x)
        {
            if (x == 1 || x == -1)
            {
                return 1;
            }
            else if (x >= 0 && x != 1)
            {
                return -1 / (1 - x);
            }
            else
            {
                return 1 / (1 + x);
            }

        }
        static void f(double x, out double y)
        {
            if (x == 1 || x == -1)
            {
                y = 1;
            }
            else if (x >= 0 && x != 1)
            {
                y = -1 / (1 - x);
            }
            else
            {
                y = 1 / (1 + x);
            }
        }
        void Main()
        {
            while(true)
            {
                Console.WriteLine("Введите a,b,h:");
                if (Int32.TryParse(Console.ReadLine(), out a) &&
                    Int32.TryParse(Console.ReadLine(), out b) &&
                    Int32.TryParse(Console.ReadLine(), out h))
                {
                    Console.WriteLine("Через double f(x):");
                    for (int i = a; i < b + 1; i += h)
                    {
                        Console.WriteLine(i + " - " + f(i));
                    }

                    Console.WriteLine("Через static void f(x):");
                    for (int i = a; i < b + 1; i += h)
                    {
                        f(i, out y);
                        Console.WriteLine(i + " - " + y);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то, попробуйте ещё раз");
                }

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}
