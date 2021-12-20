using System;

namespace prac61console
{
    class prac
    {
        Random r = new Random();
        public prac()
        {
            InOne();
            InTwo();
        }
        int[] arr1;
        int[,] arr2;
        int k, n;

        void InOne()
        {
            Console.WriteLine("одномерный:");
            while (true)
            {
                Console.WriteLine("Введите размер массива:");
                if (Int32.TryParse(Console.ReadLine(), out k))
                {
                    arr1 = new int[k];
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        arr1[i] = r.Next(-10,10);
                        Console.WriteLine($"{i + 1}-ый элемент массива: {arr1[i]}");
                    }
                    Console.WriteLine("Нечётные элементы массива:");
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] % 2 == 1 || arr1[i] % 2 == -1)
                        {
                            Console.Write(arr1[i] + " ");
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
        void InTwo()
        {
            Console.WriteLine("\n\nдвумерный:");
            Console.WriteLine("Введите размер массива NxN:");
            while (true)
            {
                Console.Write("N: ");
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    arr2 = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr2[i, j] = r.Next(-10,10);
                            Console.WriteLine($"[{i+1},{j+1}]-ый элемент матрицы равен - {arr2[i,j]}");
                        }
                    }
                    Console.WriteLine("Нечётные элементы массива:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (arr2[i, j] % 2 == 1 || arr2[i, j] % 2 == -1) { Console.Write(arr2[i, j] + " "); }
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Рамер массива должны быть целлочисленными");
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
