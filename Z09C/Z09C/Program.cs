using System;
using System.IO;
using System.Text;
using System.Reflection;

namespace Z09C
{
    class Program
    {
        
        class prac
        {
            Random r = new Random();
            double[] dblArrIn;
            string[] strArrOut;
            double[] dblArrOut;
            double buf = Int32.MinValue;
            int k;
            int n;
            StringBuilder sb = new StringBuilder();
            StringBuilder str = new StringBuilder();
            StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\text.txt", false);

            public prac()
            {
                Main();
            }
            void Main()
            {
                while(true)
                {
                    Console.Write("Введите размер последовательности чисел ");
                    if (Int32.TryParse(Console.ReadLine(), out n) && n > 0)
                    {
                        dblArrIn = new double[n];
                        for(int i = 0; i < dblArrIn.Length; i++)
                        {
                            dblArrIn[i] = r.Next(-10, 9) + r.NextDouble();
                            sb.Append(dblArrIn[i].ToString());
                            sb.Append(" ");
                        }
                        sw.WriteLine(sb.ToString());
                        sw.Close();
                        Console.WriteLine(sb.ToString() + " - записано в файл");
                        StreamReader sr = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\text.txt");
                        str.Append(sr.ReadToEnd());
                        strArrOut = str.ToString().Split(' ');
                        dblArrOut = new double[strArrOut.Length];
                        for(int i = 0; i < n; i = i+2)
                        {
                            if(double.TryParse(strArrOut[i], out dblArrOut[i])&& dblArrOut[i] != 0)
                            {
                                buf = dblArrOut[i] > buf ? dblArrOut[i]:k=0;
                            }
                        }
                        Console.WriteLine(buf);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Размер последовательности определяется положительным целым значением");
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}
