using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        static long factorial(long n)
        {
            long s = 1;
            for (int i = 1; i <= n; i++)
                s *= i;
            return s;
        }

        if ((n >= 0) && (k >= 0))
        {
            answer = factorial(n) / (factorial(k) * factorial(n - k));
        }


        // end

        return answer;
    }
    
    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        static double GeronArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        if ((first[0] >= first[1] + first[2]) || (first[2] >= first[1] + first[0]) || (first[1] >= first[2] + first[1]) || (second[0] >= second[1] + second[2]) || (second[1] >= second[2] + second[0]) || (second[2] >= second[1] + second[0]))
            return -1;
        else if (GeronArea(first[0], first[1], first[2]) > GeronArea(second[0], second[1], second[2]))
            return 1;
        else if (GeronArea(first[0], first[1], first[2]) < GeronArea(second[0], second[1], second[2]))
            return 2;
        else
            return 0;

        // end

    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here
        static double GetDistance(double v, double a, double t)
        {
            return v * t + a * t * t / 2;
        }

        if (GetDistance(v1, a1, time) == GetDistance(v2, a2, time))
            return 0;
        else if (GetDistance(v1, a1, time) > GetDistance(v2, a2, time))
            return 1;
        else
            return 2;

        // end
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;


        // code here
        static double GetDistance(double v, double a, double t)
        {
            return v * t + a * t * t / 2;
        }
        int t = 1;
        while (GetDistance(v1, a1, t) > GetDistance(v2, a2, t))
            t++;
        answer = t;
        return answer;
        // end

    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)    
    {
        // code here

        int a = 0, b = 0, c = 0, a1 = 0, b1 = 0;
        if (A.GetLength(0) == 5 || A.GetLength(1) == 6 || B.GetLength(0) == 3 || B.GetLength(1) == 5)
        {
            static (int, int) FindMax(int[,] A)
            {
                int max = A[0, 0];
                int str = 0, stol = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        if (A[i, j] > max)
                        {
                            max = A[i, j];
                            str = i;
                            stol = j;
                        }
                    }
                }
                return (str, stol);
            }
            (a, b) = FindMax(A);
            (a1, b1) = FindMax(B);
            Console.WriteLine(b);
            c = A[a, b];
            A[a, b] = B[a1, b1];
            B[a1, b1] = c;
        }
        // end
    }

    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMax(array);

        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here
        if ((B.GetLength(0) == 5) && (C.GetLength(0) == 6) && (C.GetLength(1) == 6) && (B.GetLength(1) == 5))
        {
            int[,] B1 = new int[B.GetLength(0) - 1, B.GetLength(1)];
            int[,] C1 = new int[C.GetLength(0) - 1, C.GetLength(1)];
            static int FindDiagonalMax(int[,] A)
            {
                int max = -1000000;
                int nom = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, i] > max)
                    {
                        max = A[i, i];
                        nom = i;
                    }
                }
                return nom;
            }
            static int[,] scam(int[,] A, int a)
            {
                int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i, j] = A[i, j];
                    }
                }
                for (int i = a; i < A.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        B[i, j] = A[i + 1, j];
                    }
                }
                return B;
            }
            B1 = scam(B, FindDiagonalMax(B));
            B = B1;
            C1 = scam(C, FindDiagonalMax(C));
            C = C1;
            
            
        }
        // end
    }

    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here

        // use method FindDiagonalMax(matrix); from Task_2_3
        // use method FindDiagonalMaxIndex(matrix); from Task_2_3

        // end
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here
        
        int[] C = new int[A.GetLength(1)];
        static int FindMax(int[,] C)
        {
            int max = -10000000;
            int nom = 0;
            for (int i = 0; i < C.GetLength(0); i++)
            {
                if (C[i,0] > max)
                {
                    max = C[i,0];
                    nom = i;
                }
            }
            return nom;
        }
        int x = FindMax(A);
        int y = FindMax(B);
        for (int i = 0; i < B.GetLength(1); i++)
        {
            C[i] = B[FindMax(B), i];
        }
        for (int i = 0; i < 6; i+=1)
        {
            B[y, i] = A[x,i];
        }
        

        for (int i = 0; i < B.GetLength(1); i++)
        {
            A[FindMax(A),i] = C[i];
        }
        
        return;
        // end
    }

    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here

        // create and use DeleteElement(array, index);

        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here
        int[,] B1 = new int[5,5];
        static int Findstr(int[,] C)
        {
            int max = -1000000;
            int ch = 0;
            int nom = 0;
            for (int i = 0;i < C.GetLength(0);i++)
            {
                for (int j = 0;j < C.GetLength(1);j++)
                {
                    if (C[i, j] > 0)
                        ch++;
                }
                if (ch > max)
                {
                    max = ch;
                    nom = i;
                }
                ch = 0;
            }
            return ch;
            
        }
        static int Findstol(int[,] C)
        {
            int max = -1000000;
            int ch = 0;
            int nom = 0;
            for (int i = 0; i < C.GetLength(1); i++)
            {
                for (int j = 0; j < C.GetLength(0); j++)
                {
                    if (C[j,i] > 0)
                        ch++;
                }
                if (ch > max)
                {
                    max = ch;
                    nom = i;
                }
                ch = 0;
            }
            
            return ch;

        }
        for (int i = 0; i < Findstr(B) + 1; i++)
        {
            for (int j = 0;j < 5;j++)
            {
                B1[i,j] = B[i,j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            B1[Findstr(B) + 1, i] = C[i, Findstol(C)];
        }
        for (int i = Findstr(B) + 1; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                B1[i + 1, j] = B[i, j];
            }
        }
        
        B = B1;
        // end
    }

    public void Task_2_8(int[] A, int[] B)
    {
        // code here

        // create and use SortArrayPart(array, startIndex);

        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = new int [9];

        // code here
        
        static int Summa(int[,] C, int a)
        {
            int sum = 0;
            for (int i = 0; i < C.GetLength(0); i++)
            {
                if (C[i,a] > 0)
                    sum += C[i, a];

            }
            return sum;
        }
   
        for (int i = 0; i < 4; i++)
        {
            answer[i] = Summa(A, i);
        }

        for (int i = 4; i < 9; i++)
        {
            answer[i] = Summa(C, i - 4);
        }

        // end

        return answer;
    }

    public void Task_2_10(ref int[,] matrix)
    {
        // code here

        // create and use RemoveColumn(matrix, columnIndex);

        // end
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here
        static (int, int) FindMax(int[,] A)
        {
            int max = A[0, 0];
            int str = 0, stol = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        str = i;
                        stol = j;
                    }
                }
            }
            return (str, stol);
        }
        int x, y, x1, y1;
        (x, y) = FindMax(A);
        (x1, y1) = FindMax(B);
        int c = A[x,y];
        A[x,y] = B[x1,y1];
        B[x1,y1] = c;

        // end
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxColumnIndex(matrix);

        // end
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here
        int[,] A = new int[3,5];
        int[,] B = new int[4, 5];
        static int FindMax(int[,] A)
        {
            int max = A[0, 0];
            int str = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        str = i;
                    }
                }
            }
            return str;
        }
        
        static int FindMin(int[,] A)
        {
            int min = A[0, 0];
            int str = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        str = i;
                    }
                }
            }
            return str;
        }

        static int[,] scam(int[,] A, int a)
        {
            int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0;j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            for (int i = a; i < A.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    B[i, j] = A[i+1, j];
                }
            }
            return B;
        }
        if (FindMax(matrix) != FindMin(matrix))
        {
            B = scam(matrix,FindMax(matrix));
            A = scam(B, FindMin(B));
            matrix = A;
        }
        else
        {
            B = scam(matrix, FindMax(matrix));
            matrix = B;
        }    

            // end
        }
    
    public void Task_2_14(int[,] matrix)
    {
        // code here


        // end
    }
    
    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0; // 1 - increasing   0 - no sequence   -1 - decreasing

        // code here
        static (int,int) FindMax(int[,] A)
        {
            int max = A[0, 0];
            int str = 0;
            int stol = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        str = i;
                        stol = j;
                    }
                }
            }
            return (str,stol);
        }

        static (int,int) FindMin(int[,] A)
        {
            int min = A[0, 0];
            int str = 0;
            int stol = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        str = i;
                        stol = j;
                    }
                }
            }
            return (str,stol);
        }
        static int summa(int[,] A)
        {
            int x,y,x1,y1;
            (x,y) = FindMax(A);
            (x1,y1) = FindMin(A);
            A[x,y] = 0;
            A[x1,y1] = 0;
            int qw = A.GetLength(0) * A.GetLength(1) - 2;
            int sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0;j < A.GetLength(1); j++)
                {
                    sum += A[i,j];
                }
            }
            return sum / qw;
        }
        if ((summa(A) < summa(B)) && (summa(B) < summa(C)))
        {
            return 1;
        }
        else if ((summa(A) >= summa(B)) && (summa(B) >= summa(C)))
            return -1;
        else
        {
            return 0;
        }
        // end


    }    

    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);

        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here
        static (int, int) FindMax(int[,] A)
        {
            int max = A[0, 0];
            int str = 0;
            int stol = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        str = i;
                        stol = j;
                    }
                }
            }
            return (str, stol);
        }

        static int [,] sort(int[,] A)
        {
            int[,] B = new int[A.GetLength(0),A.GetLength(1)];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            int x, y;
            for (int i = 0; i < A.GetLength(0);i++)
            {
                (x, y) = FindMax(B);
                for (int j = 0;j < A.GetLength(1);j++)
                {
                    A[i,j] = B[x,j];
                    B[x, j] = -100000;
                }
            }
            return A;
        }

        A = sort(A);
        B = sort(B);
        
    }

    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here

        // create and use SortDiagonal(matrix);

        // end
    }

    public void Task_2_19(ref int[,] matrix)
    {
        // code here
        int[,] B = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
        static int[,] scam(int[,] A, int a)
        {
            int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            for (int i = a; i < A.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i + 1, j];
                }
            }
            return B;
        }
        int qw = 0;
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        qw++;
                    }
                }
                if (qw > 0)
                {
                    matrix = scam(matrix, i);
                }
                qw = 0;
            }
        }

        

        // end
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here

        // use RemoveColumn(matrix, columnIndex); from 2_10

        // end
    }    

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = [5];
        answerB = [6];

        // code here
        static int FindMin(int[,] A, int a)
        {
            int max = A[0, 0];
            int str = a;
            for (int i = a; i < A.GetLength(0); i++)
            {
               
                    if (A[a,i] < max)
                    {
                        max = A[a,i];
                        str = i;
                    }
                
            }
            return str;
        }

        static int [] Form(int[,] A)
        {
            int[] B = new int[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int x = FindMin(A, i);
                B[i] = A[i, x];
            }
            return B;
        }


        answerA = Form(A);
        answerB = Form(B);
        
            // end
        }

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here

        // create and use GetNegativeCountPerRow(matrix);
        // create and use GetMaxNegativePerColumn(matrix);

        // end
    }
    public void Matrix_to_array(double[,] A, ref double[] arr)
    {
        int n = A.GetLength(0), m = A.GetLength(1), k = 0;
        arr = new double[n * m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arr[k++] = A[i, j];
            }
        }
    }

    public void rock_sort(ref double[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (a[j] < a[j + 1])
                {
                    double buf = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = buf;
                }
            }
        }
    }

    public void MatrixValuesChange(ref double[,] A, double[] mxA)
    {
        int n = A.GetLength(0), m = A.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (mxA[0] == A[i, j] || mxA[1] == A[i, j] || mxA[2] == A[i, j] || mxA[3] == A[i, j] || mxA[4] == A[i, j])
                {
                    A[i, j] *= A[i, j] > 0 ? 2 : 0.5;
                }
                else A[i, j] *= A[i, j] > 0 ? 0.5 : 2;
            }
        }
    }
    public void Task_2_23( double[,] A, double[,] B)
    {
        // code here
        double[] mxAt = new double [2];
        double[] mxBt = new double[3];

        Matrix_to_array(A, ref mxAt);
        Matrix_to_array(B, ref mxBt);

        rock_sort(ref mxAt);
        rock_sort(ref mxBt);

        double[] mxA = mxAt.Length >= 5 ? new double[5] : new double[mxAt.Length], mxB = mxBt.Length >= 5 ? new double[5] : new double[mxBt.Length];
        for (int i = 0; i < mxA.Length; i++)
        {
            mxA[i] = mxAt[i];
        }
        for (int i = 0; i < mxB.Length; i++)
        {
            mxB[i] = mxBt[i];
        }

        MatrixValuesChange(ref A, mxA);
        MatrixValuesChange(ref B, mxB);


        // end

    }
        

    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMax(matrix); from 2_1

        // end
    }

    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here
        static int FindMax(int[,] A)
        {
            int max = 0;
            int nom = 0;
            int ch = 0;
            for (int i = 0; i  < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < 0)
                    {
                        ch++;
                    }
                }
                if (ch > max)
                {
                    max = ch;
                    nom = i;
                }
                ch = 0;
            }
            return nom;
        }

        maxA = FindMax(A);
        maxB = FindMax(B);


            // end
        }

    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here

        // use GetNegativeCountPerRow(matrix); from 2_22
        // create and use FindMaxIndex(array);

        // end
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here
        static int FindMax(int[,] A, int a)
        {
            int max = A[a,0];
            int nom = 0;
            for (int i = 0;i < A.GetLength(1); i++)
            {
                if ((A[a,i] > max))
                {
                    max = A[a,i];
                    nom = i;
                    
                }
            }
            return nom;
        }

        static int [,] perem(int[,] A)
        {
            if (A.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < A.GetLength(0); i+=2)
                {
                    int j = FindMax(A,i);
                    A[i,j] = A[i,j] * (j+1);
                    j = FindMax(A,i+1);
                    A[i+1, j] = 0;
                }
            }
            else
            {
                for (int i = 0; i < A.GetLength(0)-1; i += 2)
                {
                    int j = FindMax(A, i);
                    A[i, j] = A[i, j] * (j + 1);
                    j = FindMax(A, i+1);
                    A[i+1, j] = 0;
                }

                int x = FindMax(A, A.GetLength(0)-1);
                A[A.GetLength(0)-1, x] *= (x+1);
            }
            return A;
        }
        A = perem(A);
        B = perem(B);
        for (int i = 0;i < 5;i ++)
        {
            for (int j = 0; j < 5;j ++)
            {
                Console.Write(A[i,j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

            // end
        }

    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing

        // end
    }

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a

        // end
    }

    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b

        // end
    }
    #endregion

    #region Level 3
    public delegate double SumFunction(int i, double x, ref int change);
    public delegate double YFunction(double x);
    public double s1Term(int i, double x, ref int iFactorial)
    {
        if (i > 0)
            iFactorial *= i;

        return Math.Cos(i * x) / iFactorial;
    }
    public double s2Term(int i, double x, ref int sign)
    {
        sign *= -1;
        return sign * Math.Cos(i * x) / (i * i);
    }
    public double y3_1_1(double x)
    {
        return Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
    }
    public double y3_1_2(double x)
    {
        return ((x * x) - Math.PI * Math.PI / 3) / 4;
    }
    public double CalculateSum(SumFunction sumFunction, double x, int i)
    {
        double epsilon = 0.0001, sum = 0;
        int change = 1;
        double curTerm = sumFunction(i, x, ref change);

        while (Math.Abs(curTerm) > epsilon)
        {
            sum += curTerm;
            curTerm = sumFunction(++i, x, ref change);
        }
        return sum;
    }
    public void GetSumAndY(SumFunction sFunction, YFunction yFunction, double a, double b, double h, double[,] SumAndY, int startI = 0)
    {
        for (int i = 0; i < (b - a) / h + 1; i++)
        {
            double x = a + i * h;

            double sum = CalculateSum(sFunction, x, startI);
            double y = yFunction(x);

            SumAndY[i, 0] = sum;
            SumAndY[i, 1] = y;
        }
    }
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {

        // code here 
        double a1 = 0.1, b1 = 1, h1 = 0.1;
        firstSumAndY = new double[(int)((b1 - a1) / h1) + 1, 2];
        GetSumAndY(s1Term, y3_1_1, a1, b1, h1, firstSumAndY);


        double a2 = Math.PI / 5, b2 = Math.PI, h2 = Math.PI / 25;
        secondSumAndY = new double[(int)((b2 - a2) / h2) + 1, 2];
        GetSumAndY(s2Term, y3_1_2, a2, b2, h2, secondSumAndY, 1);

        // end
    }




    public void Task_3_2(int[,] matrix)
    {
        // SortRowStyle sortStyle = default(SortRowStyle); - uncomment me

        // code here

        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

        // end
    }


    public delegate void SwapDirection(double[] arr);

    public void SwapRight(double[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i += 2)
        {
            (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
        }
    }

    public void SwapLeft(double[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i -= 2)
        {
            (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
        }
    }

    public double GetSum(double[] arr)
    {
        double s = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            s += arr[i];
        }
        return s;
    }
    public double Task_3_3(double[] array)
    {
        
        // SwapDirection swapper = default(SwapDirection); - uncomment me
        double answer = 0, s = 0;
        SwapDirection swapper = default(SwapDirection);

        // code here
        foreach (double elem in array) s += elem;
        double average = s / array.Length;

        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array) and GetSum(array)
        // change method in variable swapper in the loop here and use it for array swapping

        // end
        if (array[0] > average) swapper = SwapRight;
        else swapper = SwapLeft;
        swapper(array);
        answer = GetSum(array);

        return answer;
        
    }

    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // and GetSum(GetTriangle, matrix)
        // create and use method GetSum(array) similar to GetSum in Task_3_3

        // end

        return answer;
    }
    public delegate int Function (double a, double b, double h);
    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;

        // code here
        static int  function1(double a, double b, double h)
        {
            int s = 1;
            double f = 0;
            f = a * a - Math.Sin(a);
            int znak = 0;
            if (f <= 0)
                znak = -1;
            else
                znak = 1;
                
            for (double i = a + h; i <= b; i+=h)
            {
                f = i * i + Math.Sin(i);
                if (((f < 0) && (znak > 0)) || ((f > 0) && (znak < 0)))
                {
                    s++;
                }
                if (f < 0)
                    znak = -1;
                else
                    znak = 1;
            }
            return s;
        }
        static int function2(double a, double b, double h)
        {
            int s = 1;
            double f = 0;
            f = Math.Exp(a) - 1;
            int znak = 0;
            if (f <= 0)
                znak = -1;
            else
                znak = 1;

            for (double i = a + h; i <= b; i += h)
            {
                f = Math.Exp(i) - 1;
                if (((f < 0) && (znak > 0)) || ((f > 0) && (znak < 0)))
                {
                    s++;
                }
                if (f < 0)
                    znak = -1;
                else
                    znak = 1;
            }
            return s;
        }

        Function funk = function1;
        func1 = funk(0, 2, 0.1);
        Function funk1 = function2;
        func2 = funk1(-1, 1, 0.2);




       
        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
    }

    public void Task_3_6(int[,] matrix)
    {
        // code here

        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) from Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        // end
    }
    public delegate int CountPositive(int[,] matrix);
    
    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here
        int[,] B1 = new int[5, 5];
        static int Findstr(int[,] C)
        {
            int max = -1000000;
            int ch = 0;
            int nom = 0;
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (C[i, j] > 0)
                        ch++;
                }
                if (ch > max)
                {
                    max = ch;
                    nom = i;
                }
                ch = 0;
            }
            return ch;

        }
        static int Findstol(int[,] C)
        {
            int max = -1000000;
            int ch = 0;
            int nom = 0;
            for (int i = 0; i < C.GetLength(1); i++)
            {
                for (int j = 0; j < C.GetLength(0); j++)
                {
                    if (C[j, i] > 0)
                        ch++;
                }
                if (ch > max)
                {
                    max = ch;
                    nom = i;
                }
                ch = 0;
            }

            return ch;

        }
        CountPositive poisk = Findstr;
        CountPositive poisk1 = Findstol;
        for (int i = 0; i < poisk(B) + 1; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                B1[i, j] = B[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            B1[poisk(B) + 1, i] = C[i, poisk1(C)];
        }
        for (int i = Findstr(B) + 1; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                B1[i + 1, j] = B[i, j];
            }
        }

        B = B1;
        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7

        // end
    }

    public void Task_3_10(ref int[,] matrix)
    {
        // FindIndex searchArea = default(FindIndex); - uncomment me

        // code here

        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        // end
    }
    public delegate int Find1(int[,] matrix);
    public void Task_3_13(ref int[,] matrix)
    {
        // code here
        int[,] A = new int[3, 5];
        int[,] B = new int[4, 5];
        static int FindMax(int[,] A)
        {
            int max = A[0, 0];
            int str = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        str = i;
                    }
                }
            }
            return str;
        }

        static int FindMin(int[,] A)
        {
            int min = A[0, 0];
            int str = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        str = i;
                    }
                }
            }
            return str;
        }

        static int[,] scam(int[,] A, int a)
        {
            

            int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            for (int i = a; i < A.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < A.GetLength(1) - 1; j++)
                {
                    B[i, j] = A[i + 1, j];
                }
            }
            return B;
        }
        Find1 find = FindMin;
        Find1 find1 = FindMax;
        if (find1(matrix) != find(matrix))
        {
            B = scam(matrix, find1(matrix));
            A = scam(B, find(B));
            matrix = A;
        }
        else
        {
            B = scam(matrix, FindMax(matrix));
            matrix = B;
        }
        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }

    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here

        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        // end
    }
    public delegate int Find(int[,] A, int a);
    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here
        static int FindMax(int[,] A, int a)
        {
            int max = A[a, 0];
            int nom = 0;
            for (int i = 0; i < A.GetLength(1); i++)
            {
                if ((A[a, i] > max))
                {
                    max = A[a, i];
                    nom = i;

                }
            }
            return nom;
        }
        
        static int[,] perem(int[,] A)
        {
            Find find = FindMax;
            if (A.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < A.GetLength(0); i += 2)
                {
                    int j = find(A, i);
                    A[i, j] = A[i, j] * (j + 1);
                    j = find(A, i + 1);
                    A[i + 1, j] = 0;
                }
            }
            else
            {
                for (int i = 0; i < A.GetLength(0) - 1; i += 2)
                {
                    int j = find(A, i);
                    A[i, j] = A[i, j] * (j + 1);
                    j = find(A, i + 1);
                    A[i + 1, j] = 0;
                }

                int x = find(A, A.GetLength(0) - 1);
                A[A.GetLength(0) - 1, x] *= (x + 1);
            }
            return A;
        }
        A = perem(A);
        B = perem(B);
        
        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }

    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }

    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);

        // end
    }
    #endregion
    #region bonus part
    public delegate void MatrixConverter(double[,] matrix);

    public void ToUpperTriangular(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int j = 0; j < m; j++)
        {
            for (int i = j + 1; i < n; i++)
            {
                double coef = -(matrix[i, j] / matrix[j, j]);

                matrix[i, j] = 0;

                for (int k = j + 1; k < m; k++)
                {
                    matrix[i, k] += matrix[j, k] * coef;
                }
            }
        }
    }

    public void ToLowerTriangular(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int j = m - 1; j >= 0; j--)
        {
            for (int i = j - 1; i >= 0; i--)
            {
                double coef = -(matrix[i, j] / matrix[j, j]);

                matrix[i, j] = 0;

                for (int k = j - 1; k >= 0; k--)
                {
                    matrix[i, k] += matrix[j, k] * coef;
                }
            }
        }
    }

    public void ToLeftDiagonal(double[,] matrix)
    {
        ToUpperTriangular(matrix);
        ToLowerTriangular(matrix);
    }

    public void ToRightDiagonal(double[,] matrix)
    {
        ToLowerTriangular(matrix);
        ToUpperTriangular(matrix);
    }
    public double[,] Task_4(double[,] matrix, int index)
    {
        // code here

        MatrixConverter[] mc = { ToUpperTriangular, ToLowerTriangular, ToLeftDiagonal, ToRightDiagonal };

        mc[index](matrix);

        return matrix;
        // end
    }




    #endregion
}
