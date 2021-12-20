using System;

namespace prac3._1_c_
{
    class prac
    {
        public prac()
        {
            In();
            Console.WriteLine(Main());
        }
        double ab, ac, cd;

        double Main()
        {
            return ab + ac + cd + f(f(ab, ac), cd);
        }
        void In()
        {
            while(true)
            {
                Console.WriteLine("Введите AB,AC,CD:");
                if (Double.TryParse(Console.ReadLine(), out ab) &&
                    Double.TryParse(Console.ReadLine(), out ac) &&
                    Double.TryParse(Console.ReadLine(), out cd))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то, попробуйте ещё раз");
                }
            }
        }
        double f(double a, double b)
        {
            double c = Math.Sqrt(a * a + b * b);
            return c;
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
