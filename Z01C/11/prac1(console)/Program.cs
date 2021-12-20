using System;

namespace prac1_console_
{
    class Circle
    {
        private double Radius = 0.0;
        private double Area = 0.0;
        private double Pi = Math.PI;
        public Circle()
        {
            fillArea();
        }

        public void fillArea()
        {
            Console.Write("Введите площадь окружности: ");
            if(Double.TryParse(Console.ReadLine(), out Area))
            {
                showCircle();
            }
            else
            {
                Console.Write("Вы ввели что-то не то, попробуйте ещё раз:\n");
                fillArea();
            }
        }
        public void showCircle()
        {
            Radius = Math.Sqrt(Area / Pi);
            Console.Write("R = (" + Area + "/Пи)^1/2 = " + Radius);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.ReadKey();
        }
    }
}
