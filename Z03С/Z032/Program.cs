using System;

namespace prac3._2_c_
{
    class prac
    {
        public prac()
        {
            Main();
        }
        int a, b, h;
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
        void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите a,b,h:");
                if (Int32.TryParse(Console.ReadLine(), out a) &&
                    Int32.TryParse(Console.ReadLine(), out b) &&
                    Int32.TryParse(Console.ReadLine(), out h))
                {
                    for (int i = a; i < b + 1; i += h)
                    {
                        Console.WriteLine(i + " - " + f(i));
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
