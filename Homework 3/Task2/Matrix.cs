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
        #region Fields and Properties
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
                for (int i = 0; i < _lineSize; i++)
                {
                    for (int j = 0; j < _columnSize; j++)
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
                for (int i = 0; i < _lineSize; i++)
                {
                    for (int j = 0; j < _columnSize; j++)
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

        public int SummFirstLine
        {
            get
            {
                int summ = 0;
                for (int i = 0; i < _columnSize; i++)
                {
                    summ = _matrix[0, i];
                }
                return summ;
            }
        }

        public int SummFirstColumn
        {
            get
            {
                int summ = 0;
                for (int i = 0; i < _lineSize; i++)
                {
                    summ = _matrix[i, 0];
                }
                return summ;
            }
        }
        #endregion
        public Matrix(int lineSize, int columnSize)
        {
            _matrix = new int[lineSize, columnSize];
        }

        #region Methods
        public void InitMatrix()
        {
            for(int i = 0; i < _lineSize; i++)
            {
                for(int j = 0; j < _columnSize; j++)
                {
                    _matrix[i, j] = 0;
                }
            }
        }

        public void InitMatrixRandom()
        {
            for (int i = 0; i < _lineSize; i++)
            {
                for (int j = 0; j < _columnSize; j++)
                {
                    _matrix[i, j] = _rnd.Next(1, 9);
                }
            }
        }

        public void UserInitMatrix()
        {
            for (int i = 0; i < _lineSize; i++)
            {
                for (int j = 0; j < _columnSize; j++)
                {
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public static Matrix MakeCopy(Matrix originalMatrix)
        {
            int i, j;
            Matrix matrixCopy = new Matrix(originalMatrix.Line, originalMatrix.Column);
            for (i = 0; i < originalMatrix.Line; i++)
            {
                for (j = 0; j < originalMatrix.Column; j++)
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
            for(int i = 0; i < firstMatrix.Line; i++)
            {
                for(int j = 0; j < firstMatrix.Column; j++)
                {
                    firstMatrix[i, j] *= secondMatrix[i, j];
                }
            }
            return firstMatrix;
        }

        public Matrix Transpose(Matrix matrix)
        {
            int temporary;
            for (int i = 0; i < matrix.Line; ++i)
            {
                for (int j = i; j < matrix.Column; ++j)
                {
                    temporary = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temporary;
                }
            }
            return matrix;
        }

        public Matrix ChangingDiagonals(Matrix matrix)
        {
            int temporary = 0;
            for (int i = 0; i < matrix.Line; i++)
            {
                for (int j = 0; j < matrix.Column; j++)
                {
                    if (i == j)
                    {
                        temporary = matrix[i, j];
                        matrix[i, j] = matrix[i, matrix.Line - 1 - j];
                        matrix[i, matrix.Line - 1 - j] = temporary;
                    }
                }    
            }  
            return matrix;
        }

        public Matrix SortByColumn(Matrix matrix)
        {
            int temporary = 0;
            for (int i = 0; i < matrix.Line; i++)
            {
                for (int j = 0; j < matrix.Column; j++)
                {
                    for (int k = j; k < matrix.Column; k++)
                    {
                        if ((matrix[i, j] < matrix[i, k]) && (matrix[i, j] > 0))
                        {
                            temporary = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = temporary;
                        }
                    }
                }
            }
            return matrix;
        }
        #endregion
    }
}
