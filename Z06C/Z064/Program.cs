using System;

namespace prac64console
{
    class prac
    {
        public prac()
        {
            Main();
        }
        Random r = new Random();
        int[][] arr;
        int[] secArr;
        int n, k1, k2;
        void Main()
        {
            Console.WriteLine("Введите целочисленное значение для массива NxN");
            while(true)
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    arr = new int[n][];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = new int[n];
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr[i][j] = r.Next(-10, 10);
                            Console.WriteLine($"Элемент матрицы ({i + 1},{j + 1}) = {arr[i][j]}");
                        }
                    }
                    while(true)
                    {
                        while (true)
                        {
                            Console.Write("Введите k1: ");
                            if (Int32.TryParse(Console.ReadLine(), out k1) && k1 > 0) { break; }
                            else { Console.WriteLine("Элемент k1 должен быть целочисленным"); }
                        }
                        while (true)
                        {
                            Console.Write("Введите k2: ");
                            if (Int32.TryParse(Console.ReadLine(), out k2) && k2>0) { break; }
                            else { Console.WriteLine("Элемент k2 должен быть целочисленным"); }
                        }
                        if(k1<k2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введите К1 и К2 так, чтобы К1 была больше К2");
                        }
                    }                    
                    secArr = new int[n];
                    if (k2 - k1 > 0 && k1 > 0 && k2 > 0)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            secArr[i] = 0;
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = k1 - 1; j < k2; j++)
                            {
                                secArr[i] += arr[i][j];
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(secArr[i] + " ");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Значение размера матрицы должно быть целочисленным");
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
