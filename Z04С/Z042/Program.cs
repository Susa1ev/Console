using System;

namespace Z042
{
    class prac
    {
        public prac()
        {
            while(true)
            {
                Console.WriteLine("Введите n:");
                if (Int32.TryParse(Console.ReadLine(), out k))
                {
                    rec(k, i);
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то, попробуйте ещё раз");
                }

            }
        }
        int i = 0, k;
        void str(int i, string c)
        {
            int j = 0;
            while (j < i)
            {
                j++;
                Console.Write(c);
            }
        }
        void rec(int n, int i)
        {
            if (n >= 0)
            {
                str(i, "*");
                str(n, " ");
                str(i, "*");
                Console.WriteLine();
                rec(n - 2, i + 1);
                str(i, "*");
                str(n, " ");
                str(i, "*");
                Console.WriteLine();
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
