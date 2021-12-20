using System;

namespace prac62console
{
    class prac
    {
        Random r = new Random();
        public prac()
        {
            Main();
        }
        int n;
        double F = Int32.MinValue;
        double[] arr;
        void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите размер массива:");
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    arr = new double[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = r.Next(-10, 9) + r.NextDouble();
                        Console.WriteLine($"{i + 1}-ый элемент массива: {arr[i]}");
                        if (arr[i] < 0 && arr[i] > F) { F = arr[i]; }
                    }
                    Console.WriteLine("Максимальное число из отрицательных: " + F);
                    break;
                }
                else
                {
                    Console.WriteLine("Размер массива должен быть целочисленным");
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

