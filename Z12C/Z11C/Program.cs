using System;

namespace Z12C
{
    class Rectangle
    {
        int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Out()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Периметр = " + Per());
            Console.WriteLine("Площадь = " + Area());
        }
        public int Per()
        {
            return a + a + b + b;
        }
        public int Area()
        {
            return a * b;
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public bool IsSquare
        {
            get
            {
                if(a==b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int this[int index]
        {
            get
            {
                if (index == 0) return a;
                if (index == 1) return b;
                else
                {
                    Console.WriteLine("Введён неверный индекс!");
                    return 0;
                }
            }
        }
        public static Rectangle operator ++(Rectangle side) => new Rectangle(++side.a, ++side.b);
        public static Rectangle operator --(Rectangle side) => new Rectangle(--side.a, --side.b);
        public static bool operator true(Rectangle side) => side.IsSquare;
        public static bool operator false(Rectangle side) => side.IsSquare;
        public static Rectangle operator *(Rectangle side, int scl) => new Rectangle(side.a = side.a * scl, side.b = side.b * scl);
        public static explicit operator string(Rectangle side)
        {
            return ($"{side.a} {side.b}");
        }
        public static explicit operator Rectangle(string str)
        {
            string[] buf = str.Split(" ");
            return new Rectangle(Convert.ToInt32(buf[0]), Convert.ToInt32(buf[1]));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, bufA, bufB;
            while (true)
            {
                Console.WriteLine("Введите стороны прямоугольника (целочисленные): ");
                if(Int32.TryParse(Console.ReadLine(), out a) && Int32.TryParse(Console.ReadLine(), out b) && a> 0 && b > 0) {break;}
                else{Console.WriteLine("Стороны прямогульника должны принимать целые положительные значения");}
            }
            Rectangle r = new Rectangle(a, b);
            Console.WriteLine("\nДанные о прямоугольнике:");
            r.Out();
            Console.WriteLine("Изменить данные A");
            if (Int32.TryParse(Console.ReadLine(), out bufA)) 
            {
                Console.WriteLine("Данные А до изменения: " + r.A);
                r.A = bufA;
            }
            else { Console.WriteLine("Вы ввели не целое число"); }
            Console.WriteLine("Изменить данные B");
            if (Int32.TryParse(Console.ReadLine(), out bufB)) 
            {
                Console.WriteLine("Данные А до изменения: " + r.B);
                r.B = bufB;
            }
            else { Console.WriteLine("Вы ввели не целое число"); }
            if(r.IsSquare)
            {
                Console.WriteLine("Это квадрат");
            }
            else
            {
                Console.WriteLine("Это не квадрат");
            }
            r++;
            Console.WriteLine(r.A);
            r--;
            Console.WriteLine(r.B);
            string s = "12 35";
            Rectangle rr = (Rectangle)s;
            rr.Out();
        }
    }
}