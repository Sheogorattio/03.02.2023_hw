using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    public class Matrix
    {
        private double[,] _matrix;
        public double[,] _Matrix
        {
            get { return _matrix; }
            set
            {
                _matrix = value;
                Rows = _matrix.GetLength(0);
                Columns = _matrix.GetLength(1);
            }
        }
        public double this[int i, int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = value;}
        }
        public Matrix(int rows, int columns)        {
            Rows = rows;
            Columns = columns;
            _matrix = new double[rows, columns];
        }
        public Matrix(double[,] arr)
        {
            Rows=arr.GetLength(0);
            Columns=arr.GetLength(1);
            _matrix = arr;
        }
        public Matrix(Matrix obj)
        {
            _matrix = new double[obj.Rows,obj.Columns];
            _matrix = obj._matrix;
            Rows = obj.Rows;
            Columns = obj.Columns;
        }
        public Matrix()
        {
            _matrix = new double[0,0];
            Rows = 0;
            Columns = 0;
        }
        private int rows;
        public int Rows
        {
            get { return _matrix.GetLength(0); }
            set
            {
                rows = value;
                _matrix = new double[Rows, Columns];
            }
        }
        private int columns;
        public int Columns
        {
            get { return _matrix.GetLength(0); }
            set
            {
                columns = value;
                _matrix = new double[Rows, Columns];
            }
        }
        public static Matrix operator +(Matrix A, Matrix B)
        {
            try
            {
                if (A.Rows != B.Rows || A.Columns != B.Columns) throw new Exception("Numbers of rows and columns of A and B should be equal\nError");
                Matrix C = new Matrix(A.Rows, A.Columns);
                for (int i = 0; i < C.Rows; i++)
                {
                    for (int j = 0; j < C.Columns; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
                return C;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(1);
                return null;
            }
            
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            try
            {
                if (A.Rows != B.Rows || A.Columns != B.Columns) throw new Exception("Numbers of rows and columns of A and B should be equal\nError");
                Matrix C = new Matrix(A.Rows, A.Columns);
                for (int i = 0; i < C.Rows; i++)
                {
                    for (int j = 0; j < C.Columns; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }
                return C;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(1);
                return null;
            }
        }

        public static Matrix operator*(Matrix A, double number)
        {
            Matrix C = new Matrix(A.Rows, A.Columns);
            for(int i=0; i<A.Rows; i++)
            {
                for(int j=0; j<A.Columns; j++)
                {
                    C[i,j] = A[i,j] * number;
                }
            }
            return C;
        }

        public static Matrix operator*(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.Rows, B.Columns);
            for (int i = 0; i < C.Rows; i++)
            {
                for (int j = 0; j < C.Columns; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < B.Rows; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }
        public static bool operator==(Matrix A, Matrix B)
        {
            try
            {
                if (A.Rows != B.Rows || A.Columns != B.Columns) throw new Exception("Rows or columns numbers are different. Comparison error.");
                bool flag = true;
                for (int i = 0; i < A.rows; i++)
                {
                    for (int j = 0; j < A.columns; j++)
                    {
                        if (A[i, j] != B[i, j]) return false;
                    }
                }
                return flag;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(3);
                return false;
            }
        }
        public static bool operator !=(Matrix A, Matrix B)
        {
            try
            {
                if (A.Rows != B.Rows || A.Columns != B.Columns) throw new Exception("Rows or columns numbers are different. Comparison error.");
                bool flag = true;
                for (int i = 0; i < A.rows; i++)
                {
                    for (int j = 0; j < A.columns; j++)
                    {
                        if (A[i, j] == B[i, j]) return false;
                    }
                }
                return flag;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(3);
                return false;
            }
        }
    }
}