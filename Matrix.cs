using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    class Matrix
    {
        string symbol = "";

        int m, n;

        int[,] element;

        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public Matrix() { }

        /// <summary>
        /// Nowa macierz
        /// </summary>
        /// <param name="name">Symbol macierzy</param>
        public Matrix(string name)
        {

        }

        /// <summary>
        /// Nowa macierz
        /// </summary>
        /// <param name="name">Symbol macierzy</param>
        /// <param name="rows">Ilość wierszy</param>
        /// <param name="cols">Ilość kolumn</param>
        public Matrix(string name, int rows, int cols)
        {
            symbol = name;
            m = rows;
            n = cols;
        }

    }
}
