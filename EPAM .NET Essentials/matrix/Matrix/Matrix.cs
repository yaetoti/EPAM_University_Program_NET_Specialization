using System;
using System.Runtime.Serialization;

namespace MatrixLibrary
{
    [Serializable]
    public class MatrixException : Exception
    {
        public MatrixException() : base() { }

        public MatrixException(string message) : base(message) { }

        protected MatrixException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    public class Matrix : ICloneable
    {
        private readonly double[,] matrix;

        /// <summary>
        /// Number of rows.
        /// </summary>
        public int Rows
        {
            get => matrix.GetLength(0);
        }

        /// <summary>
        /// Number of columns.
        /// </summary>
        public int Columns
        {
            get => matrix.GetLength(1);
        }
        
        /// <summary>
        /// Gets an array of floating-point values that represents the elements of this Matrix.
        /// </summary>
        public double[,] Array
        {
            get => matrix;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Matrix(int rows, int columns)
        {
            if (rows < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows));
            }

            if (columns < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(columns));
            }

            matrix = new double[rows, columns];
            for (int y = 0; y < rows; ++y)
            {
                for (int x = 0; x < columns; ++x)
                {
                    matrix[y, x] = 0;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class with the specified elements.
        /// </summary>
        /// <param name="array">An array of floating-point values that represents the elements of this Matrix.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Matrix(double[,] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            matrix = (double[,])array.Clone();
        }

        /// <summary>
        /// Allows instances of a Matrix to be indexed just like arrays.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <exception cref="ArgumentException"></exception>
        public double this[int row, int column]
        {
            get
            {
                if (row < 0 || row > Rows)
                {
                    throw new ArgumentException(nameof(row));
                }

                if (column < 0 || column > Columns)
                {
                    throw new ArgumentException(nameof(column));
                }

                return matrix[row, column];
            }

            set
            {
                if (row < 0 || row > Rows)
                {
                    throw new ArgumentException(nameof(row));
                }

                if (column < 0 || column > Columns)
                {
                    throw new ArgumentException(nameof(column));
                }

                matrix[row, column] = value;
            }
        }

        /// <summary>
        /// Creates a deep copy of this Matrix.
        /// </summary>
        /// <returns>A deep copy of the current object.</returns>
        public object Clone()
        {
            return new Matrix((double[,])matrix.Clone());
        }

        /// <summary>
        /// Adds two matrices.
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns>New <see cref="Matrix"/> object which is sum of two matrices.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 is null)
            {
                throw new ArgumentNullException(nameof(matrix1));
            }
            
            if (matrix2 is null)
            {
                throw new ArgumentNullException(nameof(matrix2));
            }

            return matrix1.Add(matrix2);
        }

        /// <summary>
        /// Subtracts two matrices.
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns>New <see cref="Matrix"/> object which is subtraction of two matrices</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 is null)
            {
                throw new ArgumentNullException(nameof(matrix1));
            }

            if (matrix2 is null)
            {
                throw new ArgumentNullException(nameof(matrix2));
            }

            return matrix1.Subtract(matrix2);
        }

        /// <summary>
        /// Multiplies two matrices.
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns>New <see cref="Matrix"/> object which is multiplication of two matrices.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 is null)
            {
                throw new ArgumentNullException(nameof(matrix1));
            }

            if (matrix2 is null)
            {
                throw new ArgumentNullException(nameof(matrix2));
            }

            return matrix1.Multiply(matrix2);
        }

        /// <summary>
        /// Adds <see cref="Matrix"/> to the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for adding.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public Matrix Add(Matrix matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (Rows != matrix.Rows || Columns != matrix.Columns)
            {
                throw new MatrixException("Matrix sizes do not match.");
            }

            Matrix resultMatrix = new Matrix(Rows, Columns);
            for (int y = 0; y < this.matrix.GetLength(0); ++y)
            {
                for (int x = 0; x < this.matrix.GetLength(1); ++x)
                {
                    resultMatrix[y, x] = this.matrix[y, x] + matrix[y, x];
                }
            }

            return resultMatrix;
        }

        /// <summary>
        /// Subtracts <see cref="Matrix"/> from the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for subtracting.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public Matrix Subtract(Matrix matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (Rows != matrix.Rows || Columns != matrix.Columns)
            {
                throw new MatrixException("Matrix sizes do not match.");
            }

            Matrix resultMatrix = new Matrix(Rows, Columns);
            for (int y = 0; y < this.matrix.GetLength(0); y++)
            {
                for (int x = 0; x < this.matrix.GetLength(1); x++)
                {
                    resultMatrix[y, x] = this.matrix[y, x] - matrix[y, x];
                }
            }

            return resultMatrix;
        }

        /// <summary>
        /// Multiplies <see cref="Matrix"/> on the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for multiplying.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public Matrix Multiply(Matrix matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (Columns != matrix.Rows)
            {
                throw new MatrixException("Matrix sizes do not match.");
            }

            Matrix result = new Matrix(Rows, matrix.Columns);
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < matrix.Columns; ++j)
                {
                    double sum = 0;
                    for (int k = 0; k < Columns; ++k)
                    {
                        sum += this[i, k] * matrix[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        /// <summary>
        /// Tests if <see cref="Matrix"/> is identical to this Matrix.
        /// </summary>
        /// <param name="obj">Object to compare with. (Can be null)</param>
        /// <returns>True if matrices are equal, false if are not equal.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Matrix))
            {
                return false;
            }

            Matrix other = (Matrix)obj;
            if (Rows != other.Rows || Columns != other.Columns)
            {
                return false;
            }

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    if (this[i, j] != other[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    hash = hash * 23 + matrix[i, j].GetHashCode();
                }
            }

            return hash;
        }
    }
}
