using System;
using System.IO;
using System.Reflection;

namespace Z092
{
    class prac
    {
        public prac()
        {
            Main();
        }
        int k1, k2;
        string[] line;
        void Main()
        {

            try
            {
                while (true)
                {
                    Console.Write("Введите К1 и K2: ");
                    if (    Int32.TryParse(Console.ReadLine(), out k1) &&
                            Int32.TryParse(Console.ReadLine(), out k2) &&
                            k2 > k1 && k1 > 0)
                    {

                        line = File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Mavrodi.txt");
                        for (int i = k1; i <= k2; i++)
                        {
                            Console.WriteLine("\n\t\t\t\t\t\t\t" + i + " строка\n\n" + line[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("К1 должна быть положительной и меньше К2");
                    }
                }
            }
            catch
            {
                Console.WriteLine("\n\n\tВы ввели К2 больше, чем существует строк в файле, но мы вывели вам все существующие от К1 до конца");
            }
        }
    }
    class pepe
    {
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}