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
            Matrix a = new Matrix("A", 2, 4);
            Matrix b = new Matrix("B", 2, 4);

            a.EnterData();
            b.EnterData();

        }
    }
}
