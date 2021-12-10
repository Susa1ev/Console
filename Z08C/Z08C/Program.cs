using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Z08C
{
    class prac
    {
        public prac()
        {
            Main();
        }
        StringBuilder sb = new StringBuilder();
        string[] words;
        void Main()
        {
            Regex r = new Regex(@"(([01]?\d\d?|2[0-4]\d|25[0-5])\.){3}([01]?\d\d?|2[0-4]\d|25[0-5])");
            Console.Write("Введите строку: ");
            sb.Append(Console.ReadLine());
            words = sb.ToString().Split(' ');
            Console.Write("Все IPv4 в данном тексте: ");
            for (int i = 0; i < words.Length; i++)
            {
                if(r.IsMatch(words[i]))
                {
                    Console.Write(words[i] + "    ");
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
