using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    class Matrix
    {
        /// <summary>
        /// Symbol macierzy
        /// </summary>
        string symbol = "";

        /// <summary>
        /// Wymiar m (rzędy)
        /// </summary>
        int m;

        /// <summary>
        /// Wymiar n (kolumny)
        /// </summary>
        int n;

        /// <summary>
        /// Tablica z elementami danej macierzy
        /// </summary>
        int[,] element;

        /// <summary>
        /// Pusty konstruktor klasy
        /// </summary>
        public Matrix() { }

        /// <summary>
        /// Nowa macierz
        /// </summary>
        /// <param name="name">Symbol macierzy</param>
        public Matrix(string name)
        {
            symbol = name;
            Console.Write("Podaj wymiar m dla macierzy {0}:", name);
            m = int.Parse(Console.ReadLine());

            Console.Write("Podaj wymiar n dla macierzy {0}:", name);
            n = int.Parse(Console.ReadLine());

            element = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    element[i, j] = 0;
                }
            }
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

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    element[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Wprowadzenie wartości do macierzy
        /// </summary>
        public void EnterData()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Podaj element [{0},{1}] macierzy {2}", i, j, symbol);
                    element[i, j] = int.Parse(Console.ReadLine());
                }

            }
        }

        /// <summary>
        /// Wypisywanie elementów macierzy
        /// </summary>
        public void WriteData()
        {
            Console.WriteLine("Wypisywanie danych macierzy {0} o wymiarach [{1},{2}]", symbol, m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", element[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

        /// <summary>
        /// Dodawanie macierzy
        /// </summary>
        /// <param name="a">Pierwsza macierz</param>
        /// <param name="b">Druga macierz</param>
        public void AddMatrix(Matrix a, Matrix b)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    element[i, j] = a.element[i, j] + b.element[i, j];
                }
            }
        }

        /// <summary>
        /// Mnożenie macierzy przez skalar
        /// </summary>
        /// <param name="a">Macierz do wymnożenia</param>
        /// <param name="k">Skalar</param>
        public void MultipyMatrixByNumber(Matrix a, int k)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    element[i, j] = a.element[i, j] * k;
                }
            }
        }

        /// <summary>
        /// Mnożenie dwóch macierzy przez siebie
        /// </summary>
        /// <param name="a">Pierwsza macierz</param>
        /// <param name="b">Druga macierz</param>
        public void MultiplyMatrixByMatrix(Matrix a, Matrix b)
        {
            if (a.n != b.m)
            {
                throw new ArithmeticException("Niezgodne wymiary!");
            }
            element = new int[a.m, b.n];
            for (int i = 0; i < a.m; i++)
            {
                for (int j = 0; j < b.n; j++)
                {
                    element[i, j] = 0;
                    for (int r = 0; r < a.n; r++)
                    {
                        element[i, j] = a.element[i, r] * b.element[r, j];
                    }
                }
            }
        }
    }  
}
