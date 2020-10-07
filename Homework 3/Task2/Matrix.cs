using Microsoft.Win32.SafeHandles;
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
        public int Column => _columnSize;

        private int _lineSize;
        public int Line => _lineSize;

        private int[ , ] _matrix;

        public int Max
        {
            get
            {
                int maxElement = int.MinValue;
                for (int i = 0; i < _columnSize; i++)
                {
                    for (int j = 0; j < _lineSize; j++)
                    {
                        if (_matrix[i, j] > maxElement)
                        {
                            maxElement = _matrix[i, j];
                        }
                    }
                }
                return maxElement;
            }
        }

        public int Min
        {
            get
            {
                int minElement = int.MaxValue;
                for (int i = 0; i < _columnSize; i++)
                {
                    for (int j = 0; j < _lineSize; j++)
                    {
                        if (_matrix[i, j] > minElement)
                        {
                            minElement = _matrix[i, j];
                        }
                    }
                }
                return minElement;
            }
        }

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

        public static Matrix MakeCopy(Matrix originalMatrix, int column, int line)
        {
            int i, j;
            Matrix matrixCopy = new Matrix(column, line);
            for (i = 0; i < originalMatrix.Column; i++)
            {
                for (j = 0; j < originalMatrix.Line; j++)
                {
                    matrixCopy[i, j] = originalMatrix[i, j];
                }
            }
            return matrixCopy;
        }

        public int this[int i, int j]
        {
            get
            {
                return _matrix[i, j];
            }
            set
            {
                _matrix[i, j] = value;
            }
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            if(firstMatrix.Column != secondMatrix.Column && firstMatrix.Line != secondMatrix.Line)
            {
                throw new ArgumentException("Matrix sizes do not match");
            }
            for(int i = 0; i < firstMatrix.Column; i++)
            {
                for(int j = 0; j < firstMatrix.Line; j++)
                {
                    firstMatrix[i, j] *= secondMatrix[i, j];
                }
            }
            return firstMatrix;
        }

        public Matrix Transpose(Matrix matrix)
        {
            int temporary;
            for (int i = 0; i < matrix.Column; ++i)
            {
                for (int j = i; j < matrix.Line; ++j)
                {
                    temporary = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temporary;
                }
            }
            return matrix;
        }
    }
}
