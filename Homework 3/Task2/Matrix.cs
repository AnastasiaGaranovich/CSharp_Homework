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
        /// <value>
        /// public int Column => _columnSize
        /// Get Columns count
        /// </value>
        public int Column => _columnSize;

        private int _lineSize;
        /// <value>
        /// public int Line => _lineSize
        /// Get Lines count
        /// </value>
        public int Line => _lineSize;

        private int[ , ] _matrix;

        /// <value>
        /// public int Max
        /// Get Max element in the matrix
        /// </value>
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

        /// <value>
        /// public int Min
        /// Get Min element in the matrix
        /// </value>
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

        /// <value>
        ///  public int SummFirstLine
        /// Get summ of the first line in the matrix
        /// </value>
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
        /// <value>
        /// public int SummFirstColumn
        /// Get summ of the first column in the matrix
        /// </value>
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
        /// <summary>
        /// public void InitMatrix()
        /// Initialization matrix by 0
        /// </summary>
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

        /// <summary>
        /// public void InitMatrixRandom()
        /// Initialization matrix by random numbers 1-9
        /// </summary>
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

        /// <summary>
        /// public void UserInitMatrix()
        /// Initialization matrix by users numbers
        /// </summary>
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

        /// <summary>
        /// public void UserInitMatrix()
        /// Make copy of matrix
        /// </summary>
        /// <param name="originalMatrix"></param>
        /// <returns matrixCopy></returns>
        public static Matrix MakeCopy(Matrix originalMatrix)
        {
            Matrix matrixCopy = new Matrix(originalMatrix.Line, originalMatrix.Column);
            for (int i = 0; i < originalMatrix.Line; i++)
            {
                for (int j = 0; j < originalMatrix.Column; j++)
                {
                    matrixCopy[i, j] = originalMatrix[i, j];
                }
            }
            return matrixCopy;
        }

        /// <summary>
        /// public int this[int i, int j]
        /// Indexer
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
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

        /// <summary>
        /// public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        /// multiplies matrices
        /// </summary>
        /// <param name="firstMatrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns firstMatrix></returns>
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

        /// <summary>
        /// public Matrix Transpose()
        /// Transpose the matrix
        /// </summary>
        /// <returns this></returns>
        public Matrix Transpose()
        {
            if (_columnSize != _lineSize)
            {
                throw new ArgumentException("Matrix sizes do not match");
            }
            int temporary = 0;
            for (int i = 0; i < _lineSize; ++i)
            {
                for (int j = i; j < _columnSize; ++j)
                {
                    temporary = _matrix[i, j];
                    _matrix[i, j] = _matrix[j, i];
                    _matrix[j, i] = temporary;
                }
            }
            return this;
        }

        /// <summary>
        /// public Matrix ChangingDiagonals()
        /// Change matrix diagonals 
        /// </summary>
        /// <returns this></returns>
        public Matrix ChangingDiagonals()
        {
            if(_columnSize != _lineSize)
            {
                throw new ArgumentException("Matrix sizes do not match");
            }
            int temporary = 0;
            for (int i = 0; i < _lineSize; i++)
            {
                for (int j = 0; j < _columnSize; j++)
                {
                    if (i == j)
                    {
                        temporary = _matrix[i, j];
                        _matrix[i, j] = _matrix[i, _lineSize - 1 - j];
                        _matrix[i, _lineSize - 1 - j] = temporary;
                    }
                }    
            }  
            return this;
        }

        /// <summary>
        /// public Matrix SortByColumn()
        /// Sorting matrix by column
        /// </summary>
        /// <returns this></returns>
        public Matrix SortByColumn()
        {
            int temporary = 0;
            for (int i = 0; i < _lineSize; i++)
            {
                for (int j = 0; j < _columnSize; j++)
                {
                    for (int k = j; k < _columnSize; k++)
                    {
                        if ((_matrix[i, j] < _matrix[i, k]) && (_matrix[i, j] > 0))
                        {
                            temporary = _matrix[i, j];
                            _matrix[i, j] = _matrix[i, k];
                            _matrix[i, k] = temporary;
                        }
                    }
                }
            }
            return this;
        }
        #endregion
    }
}
