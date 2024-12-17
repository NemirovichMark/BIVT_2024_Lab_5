using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        answer = Factorial(n) / (Factorial(k) * Factorial(n - k));
        // create and use Factorial(n);

        // end

        return answer;
    }
    public long Factorial(int n)
    {
        long f = 1;
        for (int i = 2; i <= n; i++)
        {
            f *= i;
        }
        return f;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        double a1 = first[0], b1 = first[1], c1 = first[2];
        double a2 = second[0], b2 = second[1], c2 = second[2];
        if ( !(a1 < (b1 + c1) && b1 < (a1 + c1) && c1 < (a1 + b1)) || !(a2 < (b2 + c2) && b2 < (a2 + c2) && c2 < (a2 + b2)) ) return -1;
        double s1 = GeronArea(a1, b1, c1);
        double s2 = GeronArea(a2, b2, c2);

        if (s1 > s2) answer = 1;
        else if (s1 < s2) answer = 2;
        else answer = 0;

        // create and use GeronArea(a, b, c);
        // first = 1, second = 2, equal = 0, error = -1

        // end

        return answer;
    }
    public double GeronArea (double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }


    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;
        double s1, s2;
        s1 = GetDistance(v1, a1, time);
        s2 = GetDistance(v2, a2, time);
        if (s1 > s2) answer = 1;
        else if (s1 < s2) answer = 2;
        else answer = 0;
        // code here

        // create and use GetDistance(v, a, t); t - hours
        // first = 1, second = 2, equal = 0

        // end

        return answer;
    }
    public double GetDistance(double v, double a, int t)
    {
        double s = v * t + a * t * t / 2;
        return s;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 1;

        // code here
        for (int i = 1; GetDistance(v1, a1, answer) > GetDistance(v2, a2, answer); i++)
        {
            answer = i;
        }
        // create and use GetDistance(v, a, t); t - hours

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMax(matrix);

        // end
    }

    public void Task_2_2(double[] A, double[] B)
    {
        // code here
        if (FindMax(A) < FindMax(B))// меняем в А
        {
            double sr = 0, suma = 0;
            int k = 0;
            for (int i = FindMax(A) + 1; i < A.Length; i++)
            {
                suma += A[i];
                k++;
            }
            sr = suma / k;
            A[FindMax(A)] = sr;
            
            Console.WriteLine(sr);
        }
        else // меняем в В
        {
            double sr = 0, suma = 0;
            int k = 0;
            for (int i = FindMax(B) + 1; i < B.Length; i++)
            {
                suma += B[i];
                k++;
            }
            sr = suma / k;
            B[FindMax(B)] = sr;
            Console.WriteLine(sr);
        }
        
        // create and use FindMax(array);

        // end
    }
    public int FindMax(double[] array)
    {
        int index = -1;
        double maxi = Int32.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }
        return index;
    }
    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here

        // create and use FindDiagonalMax(matrix);

        // end
    }

    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here
        int[] t = new int [A.GetLength(1)];
        int index_A = FindDiagonalMaxIndex(A);
        for (int j = 0; j < A.GetLength(1); j++)// запоминаем строку с максимальным элементом в А
        {
            t[j] = A[index_A, j];
        }
        int[] r = new int [B.GetLength(0)];
        int index_B = FindDiagonalMaxIndex(B);
        for (int i = 0; i < B.GetLength(0); i++)// запоминаем столбец с максимальным элементом в В
        {
            r[i] = B[i, index_B];
        }
        for (int j = 0; j < A.GetLength(1); j++)// меняем строку на столбец
        {
            A[index_A, j] = r[j];
        }
        for (int i = 0; i < B.GetLength(0); i++) // меняем столбец на строку
        {
            B[i, index_B] = t[i];
        }
        // use method FindDiagonalMax(matrix); from Task_2_3
        // use method FindDiagonalMaxIndex(matrix); from Task_2_3

        // end
    }
    public int FindDiagonalMax(int[,] matrix)
    {
        int n = matrix.GetLength(0), maxi = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, i] > maxi)
            {
                maxi = matrix[i, i];
            }
        }
        return maxi;
    }
    public int FindDiagonalMaxIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), maxi = matrix[0, 0], index = 0 ;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, i] > maxi)
            {
                maxi = matrix[i, i];
                index = i;
            }
        }
        return index;
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindColumnMax(matrix, columnIndex);

        // end
    }

    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here
        DeleteElement(ref A, FindMaxi(A));
        DeleteElement(ref B, FindMaxi(B));
        int[] C = new int[A.Length + B.Length];
        int c = 0; // индекс в новом массиве
        for (int i = 0; i < A.Length; i++)
        {
            C[c] = A[i];
            c++;
        }
        for (int j = 0; j < B.Length; j++)
        {
            C[c] = B[j];
            c++;
        }
        A = C;
        // create and use DeleteElement(array, index);

        // end
    }
    public void DeleteElement(ref int[] array, int index)
    {

        int[] A = new int[array.Length - 1];
        int c = 0;// индекс в новом массиве
        for (int i = 0; i < index; i++)
        {
            A[c] = array[i];
            c++;
        }
        for (int i = index + 1; i < array.Length; i++)
        {
            A[c] = array[i];
            c++;
        }
        array = A;
    }
    public int FindMaxi(int[] array)
    {
        int index = 0;
        double maxi = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }
        return index;
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }

    public void Task_2_8(int[] A, int[] B)
    {
        // code here
        A = SortArrayPart(A, FindMaxi(A));
        B = SortArrayPart(B, FindMaxi(B));
        // create and use SortArrayPart(array, startIndex);

        // end
    }
    public int[] SortArrayPart(int[] array, int startIndex)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = startIndex + 1; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int t = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = t;
                }
            }
        }
        return array;
    }
    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here

        // create and use SumPositiveElementsInColumns(matrix);

        // end

        return answer;
    }

    public void Task_2_10(ref int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int maxi = matrix[0, 0], indexMaxi = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                if (matrix[i, j] > maxi)
                {
                    maxi = matrix[i, j];
                    indexMaxi = j;
                }
            }
        }
        int mini = matrix[0, 1], indexMini = 1;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (matrix[i, j] < mini)
                {
                    mini = matrix[i, j];
                    indexMini = j;
                }
            }
        }
        if (indexMaxi == indexMini) RemoveColumn( ref matrix, indexMaxi);
        else
        {
            RemoveColumn(ref matrix, indexMaxi);
            RemoveColumn(ref matrix, indexMini);
        }
        

        // create and use RemoveColumn(matrix, columnIndex);

        // end
    }
    public void RemoveColumn( ref int[,] matrix, int columnIndex)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[,] A = new int[n, m - 1];
        for (int j = 0; j < m - 1; j++)
        {
            if (j < columnIndex)
            {
                for (int i = 0; i < n; i++) A[i, j] = matrix[i, j];
            }
            else
            {
                for (int i = 0; i < n; i++) A[i, j] = matrix[i, j + 1];
            }
            
        }
        matrix = A;
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMax(matrix); from Task_2_1

        // end
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here
        int n = A.GetLength(0);
        int index_A = FindMaxColumnIndex(A), index_B = FindMaxColumnIndex(B);
        for (int i = 0; i < n; i++)
        {
            int t = A[i, index_A];
            A[i, index_A] = B[i, index_B];
            B[i, index_B] = t;
        }
        // create and use FindMaxColumnIndex(matrix);

        // end
    }
    public int FindMaxColumnIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int index = 0, maxi = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > maxi)
                {
                    maxi = matrix[i, j];
                    index = j;
                }
            }
        }
        return index;
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    public void Task_2_14(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            matrix = SortRow(matrix, i);
        }
        // create and use SortRow(matrix, rowIndex);

        // end
    }
    public int[,] SortRow(int[,] matrix, int rowIndex)
    {
        int m = matrix.GetLength(1);
     
       for (int j = 0; j < m - 1; j++)
       {
            for (int k = 0; k < m - j - 1; k++)
            {
                if (matrix[rowIndex, k] > matrix[rowIndex, k + 1])
                {
                    int t = matrix[rowIndex, k];
                    matrix[rowIndex, k] = matrix[rowIndex, k + 1];
                    matrix[rowIndex, k + 1] = t;
                }
            }
       }
        return matrix;
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0; // 1 - increasing   0 - no sequence   -1 - decreasing

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        return answer;
    }

    public void Task_2_16(int[] A, int[] B)
    {
        // code here
        A = SortNegative(A);
        B = SortNegative(B);
        // create and use SortNegative(array);

        // end
    }
    public int[] SortNegative(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)// сортировка вставками
        {
            if (array[i] >= 0) continue;
            int key = array[i], j = i - 1;
            while (j >= 0)
            {
                if (array[j] < 0 && array[j] < key)
                {
                    array[i] = array[j];
                    array[j] = key;
                    i = j;
                }
                j--;
            }
        }
        return array;
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }

    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here
        A = SortDiagonal(A);
        B = SortDiagonal(B);
        // create and use SortDiagonal(matrix);

        // end
    }
    public int[,] SortDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (matrix[i, i] > matrix[j, j])
                {
                    int t = matrix[i, i];
                    matrix[i, i] = matrix[j, j];
                    matrix[j, j] = t;
                }
            }

        }
        return matrix;
    }

    public void Task_2_19(ref int[,] matrix)
    {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here
        bool flag = false;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            flag = false;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                RemoveColumn(ref A, j);
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            flag = false;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                RemoveColumn(ref A, j);
            }
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            flag = false;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, j] == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                RemoveColumn(ref B, j);
            }   
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            flag = false;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, j] == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                RemoveColumn(ref B, j);
            }
        }
        // use RemoveColumn(matrix, columnIndex); from 2_10

        // end
    }

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = null;
        answerB = null;

        // code here

        // create and use CreateArrayFromMins(matrix);

        // end
    }

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here
        GetNegativeCountPerRow(matrix, out rows);
        GetMaxNegativePerColumn(matrix, out cols);
        // create and use GetNegativeCountPerRow(matrix);
        // create and use GetMaxNegativePerColumn(matrix);

        // end
    }
    public void GetMaxNegativePerColumn(int[,] matrix, out int[] cols)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        cols = new int[m];
        for (int j = 0; j < m; j++)
        {
            int maxi = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] > maxi)
                {
                    maxi = matrix[i, j];
                }
            }
            cols[j] = maxi;
        }
    }
    public void GetNegativeCountPerRow(int[,] matrix, out int[] rows)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        rows = new int[n];
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < 0) count++;
            }
            rows[i] = count;
        }
    }
    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }

    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here
        Result_2_24(ref A);
        Result_2_24(ref B);
        // use FindMax(matrix); from 2_1

        // end
    }
    public void Result_2_24(ref int[,] A)
    {
        int n= A.GetLength(0);
        int index = FindMaxColumnIndex(A);
        for (int i = 0; i < n; i++)
        {
            int t = A[i, i];
            A[i, i] = A[i, index];
            A[i, index] = t;
        }
    }
    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here

        // create and use FindMaxNegativeRow(int);
        // use GetNegativeCountPerRow(matrix); from 2_22

        // end
    }

    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here
        int row_A = FindRowWithMaxNegativeCount(A);
        int row_B = FindRowWithMaxNegativeCount(B);
        int n = A.GetLength(0), m = A.GetLength(1);
        int[] t = new int[m];
        for (int j = 0; j < m; j++)
        {
            t[j]= A[row_A, j]; //запоминаем нужную строчку в А
            A[row_A,j] = B[row_B,j];
            B[row_B,j] = t[j];
        }
        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex);

        // end
    }
    public int CountNegativeInRow(int[,] matrix, int rowIndex)
    {
        int count = 0;
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int j = 0; j < m; j++)
        {

            if (matrix[rowIndex, j] < 0) count++;
        }
        return count;
    }
    public int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int index = -1, maxi = -1;
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            int k = CountNegativeInRow(matrix, i);// считаем колво отрицательных элементов в строке
            if (k > maxi)
            {
                maxi = k;
                index = i;
            }
        }
        return index;
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here
        // create and use FindRowMaxIndex(matrix)
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }

    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // Две функции y = f1(x) и y = f2(x) заданы таблично на отрезке [A, B]. определить, является ли каждая их этих функций монотонно убывающей или
        // монотонно возрастающей на заданном отрезке. Проверку монотонности функции оформить в виде метода;

        answerFirst = FindSequence(first, 0, first.Length - 1);
        answerSecond = FindSequence(second, 0, second.Length - 1);

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
        // A and B - start and end indexes of elements from array for search

        // end
    }
    static bool up(int[] array, int A, int B)// проверка на возрастание 
    {
        bool flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] > array[i + 1]) flag = false;
        }
        return flag;
    }
    static bool down(int[] array, int A, int B)// проверка на убывание
    {
        bool flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] < array[i + 1]) flag = false;
        }
        return flag;
    }
    static int FindSequence(int[] array, int A, int B)
    {
        int answer = -2;
        if (up(array, A, B)) answer = 1;
        else if (down(array, A, B)) answer = -1;
        else answer = 0;
        return answer;
    }
    //public int FindSequence(int[] array, int A, int B) // этот метод подходит только для пункта а
    //{
    //    int count_up = 0;
    //    int count_down = 0;
    //    int answer = -2;
    //    for (int i = A; i < B ; i++)
    //    {
    //        if (array[i] < array[i + 1]) count_up++;
    //        if (array[i] > array[i + 1]) count_down++;
    //    }
    //    if (count_up == array.Length - 1) answer = 1;
    //    else if (count_down == array.Length - 1) answer = -1;
    //    else answer = 0;
    //    return answer;
    //}
    

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here
        answerFirst = FindSequence_1(first, 0, first.Length - 1);
        answerSecond = FindSequence_1(second, 0, second.Length - 1);
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a

        // end
    }
    static int[,] FindSequence_1(int[] array, int A, int B)
    {
        int c = 0;
        for (int i = A; i < B; i++)// cчитаем сколько будет интервалов(строк в будущей матрице)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) != 0) c++;
            }
        }
        int[,] matrix = new int[c, 2];
        c = 0;
        for (int i = A; i < B; i++)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) != 0)
                {
                    matrix[c, 0] = i;
                    matrix[c, 1] = j;
                    c++;
                }
            }
        }
        return matrix;
    }
    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here
        int[,] firstMatrix = FindSequence_1(first, 0, first.Length - 1);
        answerFirst = FindMaxSequence(firstMatrix);
        int[,] secondMatrix = FindSequence_1(second, 0, second.Length - 1);
        answerSecond = FindMaxSequence(secondMatrix);
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b

        // end
    }
    static int[] FindMaxSequence(int[,] matrix)
    {
        int maxi = -1, index = 0;
        int a;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            a = matrix[i, 1] - matrix[i, 0];
            if (a > maxi)
            {
                maxi = a;
                index = i;
            }
        }
        int[] answer = new int[2];
        answer[0] = matrix[index, 0];
        answer[1] = matrix[index, 1];
        return answer;
    }
    #endregion

    #region Level 3
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {
        // code here

        // create and use public delegate SumFunction(x, a, b, h) and public delegate YFunction(x, a, b, h)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
    }

    public void Task_3_2(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        SortRowStyle sortStyle = default(SortRowStyle);
        for (int i = 0; i < n; i++)
        {

            if (i % 2 == 0)
            {
                sortStyle = SortAscending;;
            }
            else
            {
                sortStyle = SortDescending;
            }
            sortStyle(matrix, i);
        }
        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

        // end
    }
    public delegate int[,] SortRowStyle(int[,] matrix, int rowIndex);
    public int[,] SortAscending(int[,] matrix, int rowIndex)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int j = 0; j < m; j++)//сортировка пузырьком
        {
            for (int k = j + 1; k < m; k++)
            {
                if (matrix[rowIndex,j] > matrix[rowIndex, k])
                {
                    int t =  matrix[rowIndex,j];
                    matrix[rowIndex,j] = matrix[rowIndex, k];
                    matrix[rowIndex,k] = t;
                }
            }
        }
        return matrix;
    }
    public int[,] SortDescending(int[,] matrix, int rowIndex)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int j = 0; j < m; j++)//сортировка пузырьком
        {
            for (int k = j + 1; k < m; k++)
            {
                if (matrix[rowIndex, j] < matrix[rowIndex, k])
                {
                    int t = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, k];
                    matrix[rowIndex, k] = t;
                }
            }
        }
        return matrix;
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
        GetTriangle Triangle;
        if (isUpperTriangle) Triangle = GetUpperTriange;
        else Triangle = GetLowerTriange;
        answer = GetSum(Triangle, matrix);
        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // and GetSum(GetTriangle, matrix)
        // create and use method GetSum(array) similar to GetSum in Task_3_3

        // end

        return answer;
    }
    public delegate int[] GetTriangle(int[,] matrix);
    public int GetSum(GetTriangle array, int[,] matrix)
    {
        int suma = 0;
        int[] A = array(matrix);
        int n = A.Length;
        for (int i = 0; i < n; i++)
        {
            suma += A[i] * A[i];
        }
        return suma;
    }
    public int[] GetUpperTriange(int [,] matrix)
    {
        int count = 0;
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < m; j++)
            {
                count++;
            }
        }
        int[] A = new int[count];
        count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < m; j++)
            {
                A[count] = matrix[i, j];
                count++;
            }
        }
        return A;
    }
    public int[] GetLowerTriange(int[,] matrix)
    {
        int count = 0;
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                count++;
            }
        }
        int[] A = new int[count];
        count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                A[count] = matrix[i, j];
                count++;
            }
        }
        return A;
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
        FindElementDelegate element_diagonal;
        element_diagonal = FindDiagonalMaxIndex;
        FindElementDelegate element_firstRow;
        element_firstRow = FindFirstRowMaxIndex;
        matrix = SwapColumns(matrix, element_diagonal, element_firstRow);
        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) from Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        // end
    }
    public delegate int FindElementDelegate(int[,] matrix);
    public int FindFirstRowMaxIndex(int[,] matrix)
    {
        int index = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[0, j] > matrix[0, index]) index = j;
        }
        return index;
    }
    public int[,] SwapColumns(int[,] matrix, FindElementDelegate diagonal, FindElementDelegate firstRow)
    {
        int index_diagonal = diagonal(matrix);
        int index_firstRow  = firstRow(matrix);
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int t = matrix[i, index_diagonal];
            matrix[i, index_diagonal] = matrix[i, index_firstRow];
            matrix[i, index_firstRow] = t;
        }
        return matrix;
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
        // code here

        FindIndex maxi = default(FindIndex);
        FindIndex mini = default(FindIndex);
        maxi = FindMaxBelowDiagonalIndex;
        mini = FindMinAboveDiagonalIndex;
        RemoveColumns(ref matrix, maxi, mini);
        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        // end
    }

    public delegate int FindIndex(int[,] matrix);
    public void RemoveColumns(ref int[,] matrix, FindIndex maxi,  FindIndex mini)
    {
        int indexMaxi = maxi(matrix);
        int indexMini = mini(matrix);
        if (indexMaxi == indexMini) RemoveColumn(ref matrix, indexMaxi);
        else
        {
            RemoveColumn(ref matrix, indexMaxi);
            RemoveColumn(ref matrix, indexMini);
        }
    }
    public int FindMaxBelowDiagonalIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int maxi = matrix[0, 0], indexMaxi = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                if (matrix[i, j] > maxi)
                {
                    maxi = matrix[i, j];
                    indexMaxi = j;
                }
            }
        }
        return indexMaxi;
    }
    public int FindMinAboveDiagonalIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int mini = matrix[0, 1], indexMini = 1;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (matrix[i, j] < mini)
                {
                    mini = matrix[i, j];
                    indexMini = j;
                }
            }
        }
        return indexMini;
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

        GetNegativeArray array_rows;
        GetNegativeArray array_cols;
        array_rows = GetNegativeCountPerRow;
        array_cols = GetMaxNegativePerColumn;
        FindNegatives(matrix, array_rows, array_cols, out rows, out cols);
        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        // end
    }
    public delegate int GetNegativeArray(int[,] matrix, int index);
    public void FindNegatives(int[,] matrix, GetNegativeArray r, GetNegativeArray col, out int[] rows, out int[] cols)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        rows = new int[n];
        cols = new int[m];
        for (int i = 0; i < n; i++)
        {
            rows[i] = r(matrix, i);
        }
        for (int j = 0; j < m; j++)
        {
            cols[j] = col(matrix, j);
        }
    }
    public int GetMaxNegativePerColumn(int[,] matrix, int column)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int maxi = Int32.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, column] < 0 && matrix[i, column] > maxi)
            {
                maxi = matrix[i, column];
            }
        }
        return maxi;
    }
    public int GetNegativeCountPerRow(int[,] matrix, int row)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int count = 0;
        for (int j = 0; j < m; j++)
        {
            if (matrix[row, j] < 0) count++;
        }
        return count;
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
        IsSequence up = FindIncreasingSequence;
        IsSequence down = FindDecreasingSequence;
        answerFirst = DefineSequence(first, up, down);
        answerSecond = DefineSequence(second, up, down);
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }
    public delegate bool IsSequence(int[] array, int left, int right);
    public bool FindIncreasingSequence(int[] array, int A, int B)
    {
        bool flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] > array[i + 1]) flag = false;
        }
        return flag;
    }
    public bool FindDecreasingSequence(int[] array, int A, int B)
    {
        bool flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] < array[i + 1]) flag = false;
        }
        return flag;
    }
    public int DefineSequence(int[] array, IsSequence up, IsSequence down)
    {
        int answer = -2;
        if (up(array, 0, array.Length - 1)) answer = 1;
        else if (down(array, 0, array.Length - 1)) answer = -1;
        else answer = 0;
        return answer;
    }
    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here
        IsSequence up = FindIncreasingSequence;
        IsSequence down = FindDecreasingSequence;
        answerFirstIncrease = FindLongestSequence(first, up);
        answerFirstDecrease = FindLongestSequence(first, down);
        answerSecondIncrease = FindLongestSequence(second, up);
        answerSecondDecrease = FindLongestSequence(second, down);
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);
        // end
    }
    public int[] FindLongestSequence(int[] array, IsSequence sequence)
    {
        int maxi = -1;
        int[] answer = new int[2];
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (sequence(array, i, j))
                { 
                    if (j - i > maxi)
                    {
                        maxi = j - i;
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
            }
        }
        return answer;
    }

    #endregion
    #region bonus part
    public double[,] Task_4(double[,] matrix, int index)
    {
        //MatrixConverter[] mc = new MatrixConverter[4]; 

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

