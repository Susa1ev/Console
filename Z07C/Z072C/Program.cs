using System.Text;
using System;

namespace Z072C
{
    class prac
    {
        StringBuilder sb = new StringBuilder();
        string[] words;
        int[] lengthOfWords;
        int buf = Int32.MaxValue;
        public prac()
        {
            Main();
        }
        void Main()
        {
            Console.Write("Введите строку: ");
            sb.Append(Console.ReadLine());
            words = sb.ToString().Split();
            lengthOfWords = new int[words.Length];
            for(int i = 0; i < words.Length;i++)
            {
                lengthOfWords[i] = words[i].Length;
                if (lengthOfWords[i] < buf) { buf = lengthOfWords[i]; }
            }
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Length == buf)
                {
                    Console.Write(words[i]+ " ");
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
