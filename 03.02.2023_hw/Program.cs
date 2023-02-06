using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02._2023_hw
{
    internal class Program
    {
        static void PrintMatrix(int[,] C)
        {
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write($"{C[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            //#region task 1
            //{
            //    Console.WriteLine("Enter 5 numbers");
            //    int[] A = new int[5];
            //    for (int i = 0; i < A.Length; i++) A[i] = Convert.ToInt32(Console.ReadLine());
            //    double sumGeneral = 0, prodGeneral = 1, maxGeneral = A[0], minGeneral = A[0], evenASum = 0, oddBColSum = 0;
            //    Console.WriteLine("\n---------------\nArray A:");
            //    for (int i = 0; i < A.Length; i++)
            //    {
            //        Console.Write($"{A[i]} ");
            //        sumGeneral += A[i];
            //        prodGeneral *= A[i];
            //        if(maxGeneral < A[i]) maxGeneral = A[i];
            //        if(minGeneral > A[i]) minGeneral = A[i];
            //        if (A[i] % 2 == 0) evenASum += A[i];
            //    }
            //    Console.WriteLine("\n---------------\nArray B:");
            //    double[,] B = new double[3, 4];
            //    for (int i = 0; i < B.GetLength(0); i++) {
            //        for (int j = 0; j < B.GetLength(1); j++)
            //        {
            //            Console.Write("{0:0.00} ", B[i, j] = r.NextDouble() * 100);
            //            sumGeneral += B[i,j];
            //            prodGeneral *= B[i, j];
            //            if (maxGeneral < B[i, j]) maxGeneral = B[i, j];
            //            if(minGeneral > B[i,j]) minGeneral = B[i,j];
            //            if (j % 2 == 0) oddBColSum += B[i, j];
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("\n---------------\nGeneral sum:\t\t{0:0.00}\nGeneral product:\t\t{1:0.00}\nGeneral max:\t\t{2:0.00}\nGeneral min:\t\t{3:0.00}\nEven values sum(A):\t\t{4}\nOdd columns values sum(B):\t\t{5:0.00}", sumGeneral, prodGeneral, maxGeneral, minGeneral, evenASum, oddBColSum);
            //}
            //#endregion
            //#region task 2
            //{
            //    int[,] arr = new int[5, 5];
            //    int maxVal = -100, minVal = 100, maxIndex = -1, minIndex = -1;
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for(int j=0; j < arr.GetLength (1); j++)
            //        {
            //            arr[i,j] = r.Next(-100,100);
            //            Console.Write($"{arr[i,j]} ");
            //            if(arr[i,j] > maxVal)
            //            {
            //                maxVal = arr[i,j];
            //                maxIndex = 5*i + j;
            //            }
            //            if(arr[i,j] < minVal)
            //            {
            //                minVal = arr[i,j];
            //                minIndex = 5*i + j;
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("----------------------------------------\nMaxIndex:\t{0}\nMinIndex:\t{1}\n", maxIndex, minIndex);
            //    int iter = 0, sum=0;
            //    if (maxIndex < minIndex) (maxIndex, minIndex) = (minIndex, maxIndex);
            //    foreach(int i in arr)
            //    {
            //        if(iter>=minIndex && iter <=maxIndex) sum+=i;
            //        iter++;
            //    }
            //    Console.WriteLine($"Sum of elements between {maxIndex}th and {minIndex}th element is {sum}.");
            //}
            //#endregion
            //#region task 3
            //{
            //    string str;
            //    Console.WriteLine("Enter text.");
            //    str = Console.ReadLine();
            //    char[] res = new char[str.Length + 1];
            //    Console.WriteLine("1.Code\n2.Decode\nEnter 1/2.");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            for(int i=0; i<str.Length; i++)
            //            {
            //                if ((str[i] >= 88 && str[i] <= 90) || (str[i] >= 120 && str[i] <= 122)) res[i] = (char)(str[i] +3 - 26);
            //                else res[i] = (char)(str[i] + 3);
            //            }
            //            break;
            //        case 2:
            //            for(int i=0; i<str.Length; i++)
            //            {
            //                if((str[i] >= 65 && str[i]<=67) || (str[i]>=97 && str[i]<=99)) res[i] = (char)(str[i] -3 + 26);
            //                else res[i] = (char)(str[i]-3);
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Error");
            //            break;
            //    }
            //    Console.WriteLine(res);
            //}
            //#endregion
            #region task 4
            {
                Console.WriteLine("Matrix A\nRows number:\t");
                int rowsA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Columns number:\t");
                int colA = Convert.ToInt32(Console.ReadLine());
                int[,] A = new int[rowsA, colA];
                Console.WriteLine("Enter values for matrix A");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                int rowsC = rowsA, colC = colA;
                Console.WriteLine("Operations:\n1.Multiply by number\n2.Add(A+B)\n3.Multiply by matrix(A*B)\nEnter 1/2/3");
                int choice = Convert.ToInt32(Console.ReadLine());
                int[,] C;
                switch (choice)
                {
                    default:
                        Console.WriteLine("Error");
                        break;
                    case 1:
                        {
                            Console.WriteLine("Enter number");
                            int num = Convert.ToInt32(Console.ReadLine());
                            C = new int[rowsC, colC];
                            for (int i = 0; i < C.GetLength(0); i++)
                            {
                                for (int j = 0; j < C.GetLength(1); j++)
                                {
                                    C[i, j] = A[i, j] + num;
                                }
                            }
                            PrintMatrix(C);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Matrix B\nRows number:\t");
                            int rowsB = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Columns number:\t");
                            int colB = Convert.ToInt32(Console.ReadLine());
                            int[,] B = new int[rowsB, colB];
                            Console.WriteLine("Enter values for matrix B");
                            for (int i = 0; i < B.GetLength(0); i++)
                            {
                                for (int j = 0; j < B.GetLength(1); j++)
                                {
                                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            if (rowsA != rowsB || colA != colB)
                            {
                                Console.WriteLine("Numbers of rows and columns of A and B should be equal\nError");
                                break;
                            }
                            C = new int[rowsA, colA];
                            for (int i = 0; i < C.GetLength(0); i++)
                            {
                                for (int j = 0; j < C.GetLength(1); j++)
                                {
                                    C[i, j] = A[i, j] + B[i, j];
                                }
                            }
                            PrintMatrix(C);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Matrix B\nRows number:\t");
                            int rowsB = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Columns number:\t");
                            int colB = Convert.ToInt32(Console.ReadLine());
                            int[,] B = new int[rowsB, colB];
                            Console.WriteLine("Enter values for matrix B");
                            for (int i = 0; i < B.GetLength(0); i++)
                            {
                                for (int j = 0; j < B.GetLength(1); j++)
                                {
                                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            colC = colB;
                            C = new int[rowsC, colC];
                            for (int i = 0; i < C.GetLength(0); i++)
                            {
                                for (int j = 0; j < C.GetLength(1); j++)
                                {
                                    C[i, j] = 0;
                                    for (int k = 0; k < rowsB; k++)
                                    {
                                        C[i, j] += A[i, k] * B[k, j];
                                    }
                                }
                            }
                            PrintMatrix(C);
                            break;
                        }
                     
                }
            
                #endregion

                Console.ReadKey();
            }
        }
    }
}
