using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix4x4 = new int[,] {
            { 1, 2, 3, 4 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 }};
        int[,] matrix7x4 = new int[,] {
            { 1,   2,  3, 4 },
            { 5,   5,  4, 6 },
            { 5,  -5,  5, -5 },
            { 6,   7,  8, 9 },
            { -6, -5, -8, 0 },
            { 11, 12, 13, 14 },
            { 6,   5,  8, 0 }};
        int[,] matrix3x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 10 } };
        int[,] matrix4x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { -11, 12, 13, 14, -15 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix5x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix6x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 0, 1, 0, 2, 0 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix4x6 = new int[,] {
            { 1, 2, 3, 4, 5, -1 },
            { 6, 7, 8, 9, 10, -2 },
            { -1, -2, -3, -4, -5, -1 },
            { 6, 7, 8, 9, 0, -2 }};
        int[,] matrix5x6 = new int[,] {
            { 1, 2, 3, 4, 5, -1 },
            { 6, 7, 8, 9, 10, -2 },
            { 11, 12, 13, 14, 15, -3 },
            { -1, -2, -3, -4, -5, -1 },
            { 6, 7, 8, 9, 0, -2 }};
        int[,] matrix6x6 = new int[,] {
            { 1,    2,  3,  4,  5,  -1 },
            { 6,    7,  8,  9,  10, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { -1,   -2, -3, -4, -5, -1 },
            { 6,    7,  8,  9,  20, -2 },
            { 1,    3,  3,  1,  5, 5 }};
        double[,] matrix2x2 = new double[,] {
            { 1, -2 },
            { 5, -5 }};
        double[,] matrix3x3 = new double[,] {
            { 1, -2, 3 },
            { 5, -5, 5 },
            { 6, 7, 8 }};
        int[] arr6 = new int[] { -3, 5, 5, 1, 0, 4 };
        int[] arr6b = new int[] { 13, 10, 1, 0, -2, -4 };
        int[] arr7 = new int[] { 1, 2, 13, 4, -5, 6, 7 };
        int[] arr7b = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int[] arr8 = new int[] { 1, 8, -3, 5, 5, 1, 0, 4 };
        int[] arr9 = new int[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 };
        int[] arr10 = new int[] { 1, -8, -3, 5, -5, 1, 0, -4, -1, 2 };
        int[] arr11 = new int[] { 1, 12, 13, 0, 9, 1, 5, -6, 7, 12, 14 };
        double[] array7 = new double[] { 1, 2, 13, 4, -5, 6, 7 };
        double[] array8 = new double[] { 1, 8, -3, 5, -5, 1, 0, 4 };
        double[] array9 = new double[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 };


        int[,] A = new int[5, 5], B = new int[6, 6];

        Array.Copy(matrix5x5, A, A.LongLength);
        Array.Copy(matrix6x6, B, B.LongLength);
        // Act

        // Act
        program.Draw(A);
        program.Draw(B);
        program.Task_2_27(A, B);

        program.Draw(A);
        program.Draw(B);

    }
    public void Draw(double[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    public void Draw(int[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        answer = Factorial(n) / Factorial(k) / Factorial(n - k);
        // create and use Factorial(n);

        // end

        return answer;
    }

    public long Factorial(int n)
    {

        long f = 1;
        for (int i = 2; i <= n; i++) f *= i;
        return f;
    }


    public int Task_1_2(double[] first, double[] second)
    {

        int answer = 0;
        if (first[0] >= (first[1] + first[2])) return -1;
        if (first[1] >= (first[0] + first[2])) return -1;
        if (first[2] >= (first[1] + first[0])) return -1;
        if (second[0] >= (second[1] + second[2])) return -1;
        if (second[1] >= (second[0] + second[2])) return -1;
        if (second[2] >= (second[1] + second[0])) return -1;
        //if (first[0] <= 0 || first[1] <= 0 || first[2] <= 0 || second[0] <= 0 || second[1] <= 0 || second[2] <= 0) return -1;
        // code here
        double areaFirst = GeronArea(first[0], first[1], first[2]);
        double areaSecond = GeronArea(second[0], second[1], second[2]);
        // create and use GeronArea(a, b, c);
        // first = 1, second = 2, equal = 0, error = -1
        if (areaFirst == areaSecond) return 0;

        if (areaFirst > areaSecond) return 1;

        if (areaFirst < areaSecond) return 2;
        // end

        return answer;
    }

    public double GeronArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        // first = 1, second = 2, equal = 0
        double distF = GetDistance(v1, a1, time);
        double distS = GetDistance(v2, a2, time);

        if (distF == distS) return 0;
        if (distF > distS) return 1;
        if (distF < distS) return 2;
        // end

        return answer;
    }


    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        int i = 1;
        while (GetDistance(v1, a1, i) > GetDistance(v2, a2, i))
        {
            i++;
        }
        Console.WriteLine(i);
        // end
        answer = i;
        return answer;
    }

    public double GetDistance(double v, double a, int t)
    {
        return v * t + a * t * t / 2;
    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMax(matrix, out int i, out int j);
        FindMax(A, out int iA, out int jA);
        FindMax(B, out int iB, out int jB);
        int temp = A[iA, jA];
        A[iA, jA] = B[iB, jB];
        B[iB, jB] = temp;
        // end
    }

    public void FindMax(int[,] matrix, out int x, out int y)
    {
        x = 0; y = 0;
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > matrix[x, y])
                {
                    x = i; y = j;
                }
            }
        }
    }
    public void FindMin(int[,] matrix, out int x, out int y)
    {
        x = 0; y = 0;
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < matrix[x, y])
                {
                    x = i; y = j;
                }
            }
        }
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
        int nb = B.GetLength(0), mb = B.GetLength(1), nc = C.GetLength(0), mc = C.GetLength(1);
        int b = FindDiagonalMax(B), c = FindDiagonalMax(C);
        int[,] newB = new int[nb - 1, mb], newC = new int[nc - 1, mc];
        // create and use FindDiagonalMax(matrix);
        for (int i = 0; i < nb - 1; i++)
        {
            if (i < b)
            {
                for (int j = 0; j < mb; j++)
                {
                    newB[i, j] = B[i, j];
                }
            }
            else
                for (int j = 0; j < mb; j++)
                {
                    newB[i, j] = B[i + 1, j];
                }
        }
        for (int i = 0; i < nc - 1; i++)
        {
            if (i < c)
            {
                for (int j = 0; j < mc; j++)
                {
                    newC[i, j] = C[i, j];
                }
            }
            else
                for (int j = 0; j < mc; j++)
                {
                    newC[i, j] = C[i + 1, j];
                }
        }
        B = newB;
        C = newC;
        // end
    }
    //  функции неизменны?  возможен ли подмен?
    public int FindDiagonalMax(int[,] matrix)
    {
        int answer = 0, n = matrix.GetLength(0);

        for (int i = 1; i < n; i++)
        {
            if (matrix[i, i] > matrix[answer, answer]) answer = i;
        }

        return answer;
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
        int nb = B.GetLength(0), mb = B.GetLength(1), na = A.GetLength(0), ma = A.GetLength(1);
        // create and use FindColumnMax(matrix, columnIndex);
        int aMax = FindColumnMax(A, 0), bMax = FindColumnMax(B, 0);
        for (int j = 0; j < ma; j++)
        {
            int temp = A[aMax, j];
            A[aMax, j] = B[bMax, j];
            B[bMax, j] = temp;
        }
        // end
    }
    public int FindColumnMax(int[,] matrix, int columnIndex)
    {
        int answer = 0, n = matrix.GetLength(0);

        for (int i = 1; i < n; i++) if (matrix[i, columnIndex] > matrix[answer, columnIndex]) answer = i;
        return answer;
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
        int nb = B.GetLength(0), mb = B.GetLength(1), nc = C.GetLength(0), mc = C.GetLength(1);
        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);
        int[,] b = new int[nb + 1, mb];
        int bi = 0, bMax = 0, cj = 0, cMax = 0;
        for (int i = 0; i < nb; i++)
        {
            int k = CountRowPositive(B, i);
            if (k > bMax)
            {
                bMax = k;
                bi = i;
            }
        }
        for (int j = 0; j < mc; j++)
        {
            int k = CountColumnPositive(C, j);
            if (k > cMax)
            {
                cMax = k;
                cj = j;
            }
        }
        for (int i = 0; i < nb; i++)
        {
            if (i <= bi)
                for (int j = 0; j < mb; j++)
                {
                    b[i, j] = B[i, j];
                }
            else
            {
                for (int j = 0; j < mb; j++)
                {
                    b[i + 1, j] = B[i, j];
                }
            }
        }
        for (int j = 0; j < mb; j++)
        {
            b[bi + 1, j] = C[j, cj];
        }
        B = b;
        // end
    }

    public int CountRowPositive(int[,] matrix, int rowIndex)
    {
        int c = 0, m = matrix.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            if (matrix[rowIndex, i] > 0) c++;
        }
        return c;
    }
    public int CountColumnPositive(int[,] matrix, int colIndex)
    {
        int c = 0, n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            if (matrix[i, colIndex] > 0) c++;
        }
        return c;
    }
    public void Task_2_8(int[] A, int[] B)
    {
        // code here

        // create and use SortArrayPart(array, startIndex);

        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here
        int na = A.GetLength(0), ma = A.GetLength(1), nc = C.GetLength(0), mc = C.GetLength(1);

        int[] a = new int[ma], c = new int[mc];
        a = SumPositiveElementsInColumns(A);
        c = SumPositiveElementsInColumns(C);
        answer = new int[ma + mc];
        for (int i = 0; i < ma; i++) { answer[i] = a[i]; }
        for (int i = ma; i < ma + mc; i++) { answer[i] = c[i - ma]; }
        // create and use SumPositiveElementsInColumns(matrix);
        for (int i = 0; i < ma + ma; i++) { Console.WriteLine(answer[i]); }
        // end

        return answer;
    }
    public int[] SumPositiveElementsInColumns(int[,] matrix)
    {
        int m = matrix.GetLength(1), n = matrix.GetLength(0);
        int[] answer = new int[m];
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] > 0) answer[j] += matrix[i, j];
            }
        }

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

        // use FindMax(matrix); from Task_2_1
        int ia, ja, ib, jb;
        FindMax(A, out ia, out ja);
        FindMax(B, out ib, out jb);
        int temp = A[ia, ja];
        A[ia, ja] = B[ib, jb];
        B[ib, jb] = temp;
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

        // create and use RemoveRow(matrix, rowIndex);
        FindMin(matrix, out int xMin, out int yMin);
        FindMax(matrix, out int xMax, out int yMax);
        if (xMin > xMax)
        {
            RemoveRow(ref matrix, xMin);
            RemoveRow(ref matrix, xMax);
        }
        else if (xMin < xMax)
        {
            RemoveRow(ref matrix, xMax);
            RemoveRow(ref matrix, xMin);
        }
        else RemoveRow(ref matrix, xMin);
        // end
    }

    public void RemoveRow(ref int[,] matrix, int rowIndex)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[,] newA = new int[n - 1, m];
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i < rowIndex)
                {
                    newA[i, j] = matrix[i, j];
                }
                else
                {
                    newA[i, j] = matrix[i + 1, j];
                }
            }
        }
        matrix = newA;
    }
    public void Task_2_14(int[,] matrix)
    {
        // code here

        // create and use SortRow(matrix, rowIndex);

        // end
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0; // 1 - increasing   0 - no sequence   -1 - decreasing

        // code here

        // create and use GetAverageWithoutMinMax(matrix);
        double[] k = new double[3] { GetAverageWithoutMinMax(A), GetAverageWithoutMinMax(B), GetAverageWithoutMinMax(C) };
        if (k[0] <= k[1] && k[1] <= k[2]) answer = 1;
        else if (k[0] >= k[1] && k[1] >= k[2]) answer = -1;
        else answer = 0;
        // end

        return answer;
    }
    public double GetAverageWithoutMinMax(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        double s = 0.0;
        int max = matrix[0, 0], min = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                s += matrix[i, j];
                if (matrix[i, j] < min) min = matrix[i, j];
                if (matrix[i, j] > max) max = matrix[i, j];
            }
        }
        s = (s - min - max) / (n * m - 2);
        return s;
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

        // create and use SortRowsByMaxElement(matrix);
        SortRowsByMaxElement(A);
        SortRowsByMaxElement(B);
        // end
    }

    public void SortRowsByMaxElement(int[,] matrix)  /////
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] max = new int[n];
        for (int i = 0; i < n; i++)
        {
            max[i] = matrix[i, 0];
            for (int j = 0; j < m; j++) if (matrix[i, j] > max[i]) max[i] = matrix[i, j];
        }

        for (int i = 1, k = 2; i < n;)
        {
            if (i == 0 || max[i] <= max[i - 1])
            {
                i = k;
                k++;
            }
            else
            {
                int temp = max[i];
                max[i] = max[i - 1];
                max[i - 1] = temp;
                for (int j = 0; j < m; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i - 1, j];
                    matrix[i - 1, j] = temp;
                }
                i--;
            }
        }

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
        int c = 0, n = matrix.GetLength(0), m = matrix.GetLength(1);
        // use RemoveRow(matrix, rowIndex); from 2_13
        for (int i = 0; i < n - c;)
        {
            bool flag = false;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag = true;
                    c++;
                    break;
                }
            }
            if (flag) RemoveRow(ref matrix, i);
            else i++;
        }
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here

        // use RemoveColumn(matrix, columnIndex); from 2_10

        // end
    }

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = null;
        answerB = null;

        // code here

        // create and use CreateArrayFromMins(matrix);
        answerA = CreateArrayFromMins(A);
        answerB = CreateArrayFromMins(B);
        // end
    }

    public int[] CreateArrayFromMins(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] mins = new int[n];
        for (int i = 0; i < n; i++)
        {
            int min = matrix[i, i];
            for (int j = i + 1; j < m; j++)
            {
                if (matrix[i, j] < min) min = matrix[i, j];
            }
            mins[i] = min;
        }
        return mins;
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

    public int[] GetNegativeCountPerRow(int[,]matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] answer = new int[n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if (matrix[i, j] < 0) answer[i]++;
            }
        }
        return answer;
    }

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);
        MatrixValuesChange(A);
        MatrixValuesChange(B);
        // end
    }
    public void MatrixValuesChange(double[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (matrix.Length <= 5)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (matrix[i,j] > 0) matrix[i,j] *= 2;
                    else matrix[i,j] /= 2;
                }
            }
            return;
        }
        int[,] max = new int[5,2] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }};
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < matrix[max[0,0], max[0,1]]) continue;
                else if (matrix[i, j] >= matrix[max[4, 0], max[4, 1]])
                {
                    max[0, 0] = max[1, 0];
                    max[0, 1] = max[1, 1];

                    max[1, 0] = max[2, 0];
                    max[1, 1] = max[2, 1];

                    max[2, 0] = max[3, 0];
                    max[2, 1] = max[3, 1];

                    max[3, 0] = max[4, 0];
                    max[3, 1] = max[4, 1];

                    max[4, 0] = i;
                    max[4, 1] = j;
                }
                else if (matrix[i, j] >= matrix[max[3, 0], max[3, 1]])
                {
                    max[0, 0] = max[1, 0];
                    max[0, 1] = max[1, 1];

                    max[1, 0] = max[2, 0];
                    max[1, 1] = max[2, 1];

                    max[2, 0] = max[3, 0];
                    max[2, 1] = max[3, 1];

                    max[3, 0] = i;
                    max[3, 1] = j;
                }
                else if (matrix[i, j] >= matrix[max[2, 0], max[2, 1]])
                {
                    max[0, 0] = max[1, 0];
                    max[0, 1] = max[1, 1];

                    max[1, 0] = max[2, 0];
                    max[1, 1] = max[2, 1];

                    max[2, 0] = i;
                    max[2, 1] = j;
                }
                else if (matrix[i, j] >= matrix[max[1, 0], max[1, 1]])
                {
                    max[0, 0] = max[1, 0];
                    max[0, 1] = max[1, 1];

                    max[1, 0] = i;
                    max[1, 1] = j;
                }
                else if (matrix[i, j] >= matrix[max[0, 0], max[0, 1]])
                {
                    max[0, 0] = i;
                    max[0, 1] = j;
                }
            }
        }

        for(int i = 0; i< n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0)
                    matrix[i, j] /= 2;
                else matrix[i, j] *= 2;
            }
        }
        for(int i = 0; i < 5; i++)
        {
            if (matrix[max[i, 0], max[i, 1]] > 0) matrix[max[i, 0], max[i, 1]] *= 4;
            else matrix[max[i, 0], max[i, 1]] /= 4;
        }
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
        int[] matrixA = GetNegativeCountPerRow(A);
        int[] matrixB = GetNegativeCountPerRow(B);
        // create and use FindMaxNegativeRow(int);
        // use GetNegativeCountPerRow(matrix); from 2_22
        maxA = FindMaxNegativeRow(matrixA);
        maxB = FindMaxNegativeRow(matrixB);
        // end
    }

    public int FindMaxNegativeRow(int[] matrix)
    {
        int n = matrix.Length;
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i] > matrix[answer])answer=i;
        }
        return answer;
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
        // create and use FindRowMaxIndex(matrix)
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);
        int[] maxIndexA = FindRowMaxIndex(A);
        int[] maxIndexB = FindRowMaxIndex(B);

        for (int i = 0; i < maxIndexA.Length; i++)
        {
            if (i % 2 == 0) ReplaceMaxElementOdd(A, i, maxIndexA[i]);
            else ReplaceMaxElementEven(A, i, maxIndexA[i]);
        }
        for (int i = 0; i < maxIndexB.Length; i++)
        {
            if (i % 2 == 0) ReplaceMaxElementOdd(B, i, maxIndexB[i]);
            else ReplaceMaxElementEven(B, i, maxIndexB[i]);
        }
        // end
    }
    public int[] FindRowMaxIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] answer = new int[n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if (matrix[i,j]> matrix[i,answer[i]]) answer[i] = j;
            }
        }
        return answer;
    }

    public void ReplaceMaxElementOdd(int[,] matrix, int row, int column)
    {
        matrix[row, column] *= (column+1);
    }
    public void ReplaceMaxElementEven(int[,] matrix, int row, int column)
    {
        matrix[row, column] = 0;
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
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)///////////        HELP
    {
        // code here

    public delegate SumFunction(x, a, b, h);
    public delegate YFunction(x, a, b, h);
        // create and use public delegate SumFunction(x, a, b, h) and public delegate YFunction(x, a, b, h)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions
        GetSumAndY(sFunction, yFunction, a, b, h)
        // end
    }

    public double sFunction(x,a,b,h){
        double s = 0,i=1, znam = i, chisl = Math.cos(i*x), elem = chisl/znam;
        while (elem>0.00001){
            s+=elem;
            i++;
            znam*=i;
            chisl = Math.cos(i*x);
                
            elem=chisl/znam;
        }
        return s+1;        
    }
    public double yFunction(x,a,b,h){
        double answer = Math.Pow(Math.Exp,Math.Cos(x))*Math.cos(Math.sin(x));
        return answer;        
    }
    public double[,] GetSumAndY(sFunction, yFunction, a, b, h){
        SumFunction sDeleg = sFunction; 
        YFunction yDeleg = yFunction;
        double[,] answer = new double[(b-a)/h,2];
        for(double x = a, int i = 0; x < b;x += h, i++){
            answer[i,0]=sDeleg(x,a,b,h);
            answer[i,1]=yDeleg(x,a,b,h);
            
        }
        
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

    public double Task_3_3(double[] array)
    {
        double answer = 0;
        // SwapDirection swapper = default(SwapDirection); - uncomment me

        // code here

        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array) and GetSum(array)
        // change method in variable swapper in the loop here and use it for array swapping

        // end

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

    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;

        // code here

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

    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here

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

    public void Task_3_13(ref int[,] matrix)
    {
        // code here

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

    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

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
    public double[,] Task_4(double[,] matrix, int index)
    {
        // MatrixConverter[] mc = new MatrixConverter[4]; - uncomment me

        // code here

        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle

        // end

        return matrix;
    }
    #endregion
}
