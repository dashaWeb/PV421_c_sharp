using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Matrix_indexer
{
    internal class Matrix
    {
        int[,] matrix;
        public Matrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder(100);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    str.Append($"{matrix[i,j], 7}");
                }
                str.AppendLine();
            }
            return str.ToString();
        }
        public int this[int r, int c]
        {
            get => matrix[r, c];
            set => matrix[r, c] = value;
        }
    }
}
