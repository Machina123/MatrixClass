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
            try
            {
                c.AddMatrix(a, b);
                c.WriteData();
            }
            catch(Exception e)
            {
                Console.WriteLine("Wystąpił błąd: {0}", e.Message.ToString());
            }
            
            Console.WriteLine(Environment.NewLine + "Macierz C = A * k");
            try
            {
                c.MultipyMatrixByNumber(a, k);
                c.WriteData();
            }
            catch(Exception e)
            {
                Console.WriteLine("Wystąpił błąd: {0}", e.Message.ToString());
            }

            Console.WriteLine(Environment.NewLine + "Macierz C = A * B");
            try
            {
                c.MultiplyMatrixByMatrix(a, b);
                c.WriteData();
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd: {0}", e.Message.ToString());
            }
            Console.ReadKey();
        }
    }
}
