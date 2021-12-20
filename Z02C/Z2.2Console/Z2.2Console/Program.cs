using System;

namespace prac2._2_c
{
    class prac
    {
        int ball;
        string result;
        public prac()
        {
            Console.WriteLine(countTheBall());
        }
        string countTheBall()
        {
        reTry:
            Console.Write("Введите балл участника от 0 до 100 ->");
            if (Int32.TryParse(Console.ReadLine(), out ball) && (ball >= 0) && (ball <= 100))
            {
                if (ball < 50)
                {
                    result = "неудовлетворительно";
                }
                else if (ball < 70)
                {
                    result = "удовлетворительно";
                }
                else if (ball < 90)
                {
                    result = "хорошо";
                }
                else if (ball < 100)
                {
                    result = "отлично";
                }
                return result;
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
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
