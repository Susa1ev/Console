using System;

namespace prac5._1c
{
    class prac
    {
        public prac()
        {
            In();
        }
        double a, b, h;
        double f(double x)
        {
            try
            {
                if (x == -0.2 || x == 2) throw new Exception();
                else return Math.Log(x - 2) / Math.Sqrt(5 * x - 1);
            }
            catch
            {
                throw;
            }
        }
        void In()
        {
            while (true)
            {
                Console.WriteLine("Введите А, В, h");
                if (Double.TryParse(Console.ReadLine(), out a) &&
                    Double.TryParse(Console.ReadLine(), out b) &&
                    Double.TryParse(Console.ReadLine(), out h))
                {
                    for (double i = a; i < b; i += h)
                    {
                        try
                        {
                            if (i <=2)
                            {
                                throw new Exception();
                            }
                            Console.WriteLine("y({0})={1:f4}", i, f(i));
                        }
                        catch
                        {
                            Console.WriteLine("y({0})=не определена", i);
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то");
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
