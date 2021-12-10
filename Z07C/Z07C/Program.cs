using System.Text;
using System;

namespace Z071C
{
    class prac
    {
        StringBuilder sb = new StringBuilder();
        char ch;
        bool flag = false;
        int bufI;
        public prac()
        {
            Main();
        }
        void Main()
        {
            Console.Write("Введите строку: ");
            sb.Append(Console.ReadLine());
            while(true)
            {
                Console.Write("Найти первое и последнее вхождение символа: ");
                if (char.TryParse(Console.ReadLine(), out ch))
                {
                    for(int i = 0; i < sb.Length; i++)
                    {
                        
                        if(sb[i] == ch)
                        {
                            bufI = i + 1;
                            if(!flag)
                            {
                                Console.WriteLine($"Символ первый раз встретился в {i + 1} символе в строке");
                                flag = true;
                            }
                        }
                    }
                    Console.WriteLine($"Символ последний раз встретился в {bufI} символе в строке");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не символ");
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
