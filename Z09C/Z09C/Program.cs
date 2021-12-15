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
            int n;
            StringBuilder sb = new StringBuilder();
            StringBuilder str = new StringBuilder();
            //StreamWriter sw = new StreamWriter("text.dat", FileMode.OpenOrCreate);/*Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + */

            public prac()
            {
                Main();
            }
            void Main()
            {
                Random r = new Random();
                if (File.Exists("inf.dat"))
                {
                    File.Delete("inf.dat");
                }
                FileStream f = new FileStream("inf.dat", FileMode.OpenOrCreate);
                BinaryWriter fOut = new BinaryWriter(f);
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    double numbs = r.Next(-10, 9) + r.NextDouble();
                    Console.WriteLine($"{i + 1} - {numbs}");
                    fOut.Write(numbs);
                }
                fOut.Close();
                FileStream ff = new FileStream("inf.dat", FileMode.Open);
                BinaryReader fIn = new BinaryReader(ff);
                double buf = double.MinValue;
                for (int i = 0; i < ff.Length; i += 8)
                {
                    ff.Seek(i, SeekOrigin.Begin);
                    double z = fIn.ReadDouble();
                    int pos = (i / 8);
                    if (pos % 2 == 0)
                    {
                        if (z > buf)
                        {
                            buf = z;
                        }
                    }

                }
                Console.WriteLine($"{buf:f4}");
            }
        }
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}
