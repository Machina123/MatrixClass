using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix("A");
            Matrix b = new Matrix("B");

            a.EnterData();
            b.EnterData();

            Console.Write("Podaj skalar: ");
            int k = int.Parse(Console.ReadLine());

            a.WriteData();
            b.WriteData();

            Matrix c = new Matrix();

            Console.WriteLine(Environment.NewLine + "Macierz C = A + B");
            if (c.AddMatrix(a, b))
            {
                c.WriteData();
            }
            else
            {
                Console.WriteLine("Wystąpił błąd!");
            }

            Console.WriteLine(Environment.NewLine + "Macierz C = A * k");
            if (c.MultipyMatrixByNumber(a,k))
            {
                c.WriteData();
            }
            else
            {
                Console.WriteLine("Wystąpił błąd!");
            }

            Console.WriteLine(Environment.NewLine + "Macierz C = A * B");
            if (c.MultiplyMatrixByMatrix(a, b))
            {
                c.WriteData();
            }
            else
            {
                Console.WriteLine("Wystąpił błąd!");
            }
            Console.ReadKey();
        }
    }
}
