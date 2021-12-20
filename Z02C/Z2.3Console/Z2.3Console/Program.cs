using System;

namespace Z2._3Console
{
    class prac
    {
        int a, b;
        public prac()
        {
            Main();
        }
        void Main()
        {
        reTry:
            Console.WriteLine("Введите А и B:");
            if (Int32.TryParse(Console.ReadLine(), out a) && Int32.TryParse(Console.ReadLine(), out b) && a < b)
            {
                Console.Write("Через For:\t\t");
                for (int i = a; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.Write("\nЧерез While:\t\t");
                int wi = a;
                while (wi < b)
                {
                    if (wi % 3 == 0)
                    {
                        Console.Write(wi + " ");
                    }
                    wi++;
                }
                Console.Write("\nЧерез do...While:\t");
                int dwi = a;
                do
                {
                    if (dwi % 3 == 0)
                    {
                        Console.Write(dwi + " ");
                    }
                    dwi++;
                } while (dwi < b);
            }
            else
            {
                goto reTry;
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
