using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Matrix
    {
        static Random _rnd = new Random();
        private int _columnSize;
        private int _lineSize;
        private int[ , ] _matrix;

        public Matrix(int columnSize, int lineSize)
        {
            _matrix = new int[columnSize, lineSize];
        }

        public void InitMatrix()
        {
            for(int i = 0; i < _columnSize; i++)
            {
                for(int j = 0; j < _lineSize; j++)
                {
                    _matrix[i, j] = 0;
                }
            }
        }

        public void InitMatrixRandom()
        {
            for (int i = 0; i < _columnSize; i++)
            {
                for (int j = 0; j < _lineSize; j++)
                {
                    _matrix[i, j] = _rnd.Next(1, 9);
                }
            }
        }

        public void UserInitMatrix()
        {
            for (int i = 0; i < _columnSize; i++)
            {
                for (int j = 0; j < _lineSize; j++)
                {
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


    }
}
