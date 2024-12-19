using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        
    }
    static int Factorial(int n)
    {
        int k = 1;
        int f = k;
        for (int i = 2; i <= n; i++)
        {
            k = k * i;
            f += k;
        }
        return f;
    }
    static long Combinations(int n, int k)
    {
        long f1 = Factorial(n);
        long f2 = Factorial(k);
        long f3 = Factorial(n - k);
        long itog = f1 / (f2 * f3);
        return itog;
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here

        // create and use Combinations(n, k);
        // create and use Factorial(n);
        
        answer = Combinations(n, k);
        // end

        return answer;
    }
    static double GeronArea(double a, double b,double c)
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        return s;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        double a1 = first[0];
        double b1 = first[1];
        double c1 = first[2];

        double a2 = second[0];
        double b2 = second[1];
        double c2 = second[2];

        if (a1 + b1 <= c1 || a1 + c1 <= b1 || c1 + b1 <= a1 || a2 + b2 <= c2 || b2 + c2 <= a2 || c2 + a2 <= b2) return -1;

        if (GeronArea(a1, b1, c1) > GeronArea(a2, b2, c2)) answer = 1;
        else if (GeronArea(a1, b1, c1) < GeronArea(a2, b2, c2)) answer = 2;
        else if (GeronArea(a1, b1, c1) == GeronArea(a2, b2, c2)) answer = 0;

        

        // create and use GeronArea(a, b, c);

        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }
    static double GetDistance(double v, double a, int t)
    {
        double S = v * t + (a * t * t) / 2;
        return S;
    }
    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        
        double answer1 = GetDistance(v1, a1, time);
        double answer2 = GetDistance(v2, a2, time);
        if (answer1 > answer2) answer = 1;
        else if (answer1 == answer2) answer = 0;
        else answer = 2;
        //Console.WriteLine(answer);
        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here

        // use GetDistance(v, a, t); t - hours
        for (int t = 1; ; t++)
        {
            if (GetDistance(v2, a2, t)>= GetDistance(v1, a1, t))
            {
                return t;
            }
        }

        // end

        return answer;
    }
    #endregion

    #region Level 2
    //10 номер => четные

    //Четные номера
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxIndex(matrix, out row, out column);

        // end
    }

    static int FindMaxIndex(double[] array)
    {
        int index = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[index]) index = i;
        }
        return index;
    }
    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        int indexA = FindMaxIndex(A);
        int indexB = FindMaxIndex(B);
        double s = 0;
        double k = 0;
        double avg;
        if (indexA < indexB)
        {
            for (int i = indexA + 1; i < A.Length; i++)
            {
                s += A[i];
                k += 1;
            }
            avg = s / k;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == A[indexA]) A[i] = avg;
            }

        }
        else if (indexA > indexB)
        {
            for (int i = indexB + 1; i < B.Length; i++)
            {
                s += B[i];
                k += 1;
            }
            avg = s / k;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == B[indexB]) B[i] = avg;
            }
        }

            // create and use FindMaxIndex(array);
            // only 1 array has to be changed!

            // end
        }
    
    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }

    static int FindDiagonalMaxIndex(int[,] matrix)
    {
        int index = 0;
        int max_z = -200;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > max_z)
            {
                max_z = matrix[i, i];
                index = i;
            }
        }

        return index;
    }
    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here
        int maxA = FindDiagonalMaxIndex(A);
        int maxB = FindDiagonalMaxIndex(B);
        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3
        for(int i = 0; i < A.GetLength(0); i++)
        {
            int t = B[i, maxB];
            B[i,maxB]=A[maxA,i];
            A[maxA,i]=t;
        }


        // end
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }

    static int FindMax(int[] array) {

        int max_el = 0;
        int max_index = 0;
        for(int i=0;i<array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el=array[i];
                max_index=i;
            }
        }
        return max_index;
    }
    static int[] DeleteElement(int[] array, int index)
    {
        int[] t = new int[array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            t[i] = array[i];
        }
        for (int i = index; i < t.Length; i++)
        {
            t[i] = array[i + 1];
        }
        return t;
    }
    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here
        int[] answer = new int[A.Length + B.Length - 2];
        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);
        int maxA = FindMax(A);
        int maxB = FindMax(B);
        A = DeleteElement(A, maxA);
        B = DeleteElement(B, maxB);
        for(int i = 0; i < A.Length; i++)
        {
            answer[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            answer[i+A.Length] = B[i];
        }
        A = answer;



        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }

    static int[] SortArrayPart(int[] array, int startIndex)
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int j=startIndex+1; j<array.Length-1-i; j++)
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
    public void Task_2_8(int[] A, int[] B)
    {
        // code here

        // create and use SortArrayPart(array, startIndex);
        A = SortArrayPart(A, FindMax(A));
        B = SortArrayPart(B, FindMax(B));


        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here

        // create and use SumPositiveElementsInColumns(matrix);

        // end

        return answer;
    }
    static int[,] RemoveColumn(int[,] matrix, int columnIndex)
    {
        int[,] answer = new int[matrix.GetLength(0),matrix.GetLength(1)-1];
        for(int i = 0; i < answer.GetLength(0); i++)
        {
            for(int j=0; j< columnIndex; j++)
            {
                answer[i,j]= matrix[i,j];
            }
            for(int j = columnIndex;j< answer.GetLength(1); j++)
            {
                answer[i,j] = matrix[i,j+1];
            }
        }

        return answer;
    }
    public void Task_2_10(ref int[,] matrix)
    {
        // code here
        int max_el = -10;
        int max_el_index = 0;
        int min_el = 100;
        int min_el_index = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i >= j)
                {
                    if (matrix[i, j] > max_el)
                    {
                        max_el = matrix[i, j];
                        max_el_index = j;
                        
                    }
                } 
                else
                {
                    if (matrix[i, j] < min_el)
                    {
                        min_el = matrix[i, j];
                        min_el_index = j;
                    }
                }
            }
        }

        Console.WriteLine($"max el ind: {max_el_index}");
        Console.WriteLine($"min el ind: {min_el_index}");

        if (max_el_index > min_el_index)
        {
            matrix = RemoveColumn(matrix, max_el_index);
            matrix = RemoveColumn(matrix, min_el_index);
        } else if (min_el_index > max_el_index)
        {
            matrix = RemoveColumn(matrix, min_el_index);
            matrix = RemoveColumn(matrix, max_el_index);
        }
        else matrix = RemoveColumn(matrix, max_el_index);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j=0;j<matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // create and use RemoveColumn(matrix, columnIndex);


        // end
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }
    static int FindMaxColumnIndex(int[,] matrix)
    {
        int index = 0;
        int max_el = matrix[0, 0];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j=0;j<matrix.GetLength(1); j++)
            {
                if (matrix[i,j]> max_el)
                {
                    max_el = matrix[i,j];
                    index = j;
                }
            }
        }
        return index;
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here
        int stA = FindMaxColumnIndex(A);
        int stB = FindMaxColumnIndex(B);
        for(int i=0;i<A.GetLength(0); i++)
        {
            int t = A[i, stA];
            A[i,stA] = B[i, stB];
            B[i,stB] = t;
        }

        // create and use FindMaxColumnIndex(matrix);
       

        // end
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    static int[,] SortRow(int[,] matrix, int rowIndex)
    {
        for(int i = 0; i < matrix.GetLength(1)-1; i++)
        {
            for(int j = 0; j < matrix.GetLength(1)-1-i; j++)
            {
                if (matrix[rowIndex, j] > matrix[rowIndex, j + 1])
                {
                    int temp = matrix[rowIndex, j];
                    matrix[rowIndex,j]=matrix[rowIndex,j+1];
                    matrix[rowIndex,j+1]=temp;
                }
            }
        }
        return matrix;
    }
    public void Task_2_14(int[,] matrix)
    {
        // code here

        // create and use SortRow(matrix, rowIndex);
        for(int i=0;i<matrix.GetLength(0); i++)
        {
            SortRow(matrix, i);
        }


        // end
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0;

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }

    static int[] SortNegative(int[] array)
    {
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) k++;
        }
        int[] newar = new int[k];
        int newar_index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { 
                newar[newar_index] = array[i];
                newar_index++;
            }
        }
        for(int i = 0; i < newar.Length - 1; i++)
        {
            for(int j = 0; j < newar.Length - 1 - i; j++)
            {
                if (newar[j] < newar[j + 1])
                {
                    int t = newar[j];
                    newar[j] = newar[j + 1];
                    newar[j + 1] = t;
                }
            }
        }
        newar_index = 0;
        for(int i=0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = newar[newar_index];
                newar_index++;
            }
        }
        return newar;
    }
    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);
        A=SortNegative(A);
        B=SortNegative(B);


        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }

    static int[,] SortDiagonal(int[,] matrix)
    {
        int[] newar = new int[matrix.GetLength(0)];
        int newar_index = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            newar[newar_index] = matrix[i, i];
            newar_index++;
        }
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for(int i = 0; i < newar.Length-1; i++)
            {
                if (newar[i] > newar[i + 1])
                {
                    int temp = newar[i];
                    newar[i] = newar[i + 1];
                    newar[i + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
            swapped = false;
            for(int i=newar.Length-2; i>=0; i--)
            {
                if (newar[i] > newar[i + 1])
                {
                    int temp = newar[i];
                    newar[i] = newar[i + 1];
                    newar[i + 1] = temp;
                    swapped = true;
                }
            }
        }
        newar_index = 0;
        for(int i=0; i < matrix.GetLength(0); i++)
        {
            matrix[i, i] = newar[newar_index];
            newar_index++;
        }
        return matrix;
    } 
    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here

        // create and use SortDiagonal(matrix);
        A = SortDiagonal(A);
        B = SortDiagonal(B);


        // end
    }

    public void Task_2_19(ref int[,] matrix)
    {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }
    static int[,] RemoveColumn1(ref int[,] matrix, int columnIndex)
    {
        int[,] nm = new int[matrix.GetLength(0), matrix.GetLength(1)-1];
        for(int j=0; j < columnIndex; j++)
        {
            for(int i = 0; i < nm.GetLength(0); i++)
            {
                nm[i,j] = matrix[i,j];
            }
        }
        for(int j = columnIndex;j< nm.GetLength(1); j++)
        {
            for (int i = 0; i < nm.GetLength(0); i++)
            {
                nm[i, j] = matrix[i, j+1];
            }
        }
        matrix = nm;
        return matrix;
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here

        // use RemoveColumn(matrix, columnIndex); from 2_10
        for(int j = A.GetLength(1)-1; j>=0;j--)
        {
            int k = 0;
            for(int i =0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == 0)
                {
                    k++;
                    break;
                }
            }
            if (k == 0) RemoveColumn1(ref A, j);
        }

        for (int j = B.GetLength(1) - 1; j >= 0; j--)
        {
            int k = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, j] == 0)
                {
                    k++;
                    break;
                }
            }
            if (k == 0) RemoveColumn1(ref B, j);
        }
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

    static int CountNegativeInRow(int[,] matrix, int rowIndex)
    {
        int k = 0;
        for(int j=0; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowIndex,j]<0) k++;
        }
        return k;
    }
    static int FindMaxNegativePerColumn(int[,] matrix,int index)
    {
        int k = -100;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i,index]<0 && matrix[i, index] > k)
            {
                k = matrix[i,index];
            }
        }
        return k;
    }
    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(1)];
        for(int i=0; i < matrix.GetLength(0); i++)
        {
            rows[i]=CountNegativeInRow(matrix, i);
        }
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            cols[j] = FindMaxNegativePerColumn(matrix,j);
        }
        // code here

        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);

        // end
    }

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }

    static void FindMaxIndex(int[,] matrix, out int row, out int column)
    {
        row = 0;
        column = 0;
        int max_el = int.MinValue;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j=0;j< matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max_el)
                {
                    max_el = matrix[i, j];
                    row = i;
                    column = j;
                }
            }
        }
    }
    static int[,] SwapColumnDiagonal(int[,] matrix, int columnIndex)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int t = matrix[i, columnIndex];
            matrix[i, columnIndex] = matrix[i, i];
            matrix[i,i]= t;
        }
        return matrix;
    }
    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);
        int row=0;
        int column=0;
        FindMaxIndex(A, out row, out column);
        A = SwapColumnDiagonal(A, column);

        FindMaxIndex(B, out row, out column);
        B = SwapColumnDiagonal(B, column);

        // end
    }

    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here

        // create and use FindRowWithMaxNegativeCount(matrix);
        // in FindRowWithMaxNegativeCount create and use CountNegativeInRow(matrix, rowIndex); like in 2_22

        // end
    }
    static int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int maxk = 0;
        int r = 0;
        for(int i=0;i < matrix.GetLength(0); i++)
        {
            if (CountNegativeInRow(matrix, i) > maxk) //созданный выше метод
            {
                maxk = CountNegativeInRow(matrix, i);
                r = i;
            }

        }
        return r;
    }
    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22
        for(int j = 0; j < A.GetLength(1); j++)
        {
            int t = A[FindRowWithMaxNegativeCount(A), j];
            A[FindRowWithMaxNegativeCount(A), j] = B[FindRowWithMaxNegativeCount(B), j];
            B[FindRowWithMaxNegativeCount(B), j] = t;
        }

        // end
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }
    static int FindSequence(int[] array, int A, int B)
    {
        int type = 0;
        bool isIncreasing = true;
        bool isDecreasing = true;
        for (int i = A; i <= B - 1; i++)
        {
            if (array[i + 1] < array[i])
            {
                isIncreasing = false;
            } else if (array[i + 1] > array[i])
            {
                isDecreasing = false;
            }
        }
        if (isIncreasing) type = 1;
        else if (isDecreasing) type = -1;
        else type = 0;
        return type;
    }
    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
        // A and B - start and end indexes of elements from array for search

        answerFirst = FindSequence(first, 0 , first.Length-1);
        answerSecond = FindSequence(second, 0, second.Length - 1);
        // end
    }

    static int[,] FindIntervals(int[] array, int A, int B)
    {
        int k = 0;
        for (int i = A; i <= B - 1; i++)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) == 1 || FindSequence(array, i, j)==-1) k++;
            }
        }
        //Console.WriteLine(k);
        int[,] m = new int[k, 2];
        int index = 0;
        for (int i = A; i <= B - 1; i++)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) == 1 || FindSequence(array, i, j) == -1)
                {
                    m[index, 0] = i;
                    m[index, 1] = j;
                    index++;
                }
            }
        }

        return m;
    }
    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search
        answerFirst = FindIntervals(first, 0, first.Length - 1);
        answerSecond = FindIntervals(second, 0, second.Length - 1);
        // end
    }

    static int[] FindMaxInterval(int[,] matrix)
    {
        int[] max_int = new int[2];
        int max_dlina = 0;
        int n = matrix.GetLength(0);
        for(int i = 0; i < n; i++)
        {
            if (matrix[i,1] - matrix[i,0] > max_dlina)
            {
                max_dlina = matrix[i, 1] - matrix[i, 0];
                max_int[0] = matrix[i, 0];
                max_int[1] = matrix[i, 1];
            }
        }
        return max_int;
    }
    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search
        answerFirst = FindMaxInterval(FindIntervals(first, 0, first.Length - 1));
        answerSecond = FindMaxInterval(FindIntervals(second, 0, second.Length - 1));
        // end
    }
    #endregion

    #region Level 3
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {
        // code here

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x

        // end
    }

    public delegate void SortRowStyle(ref int[,] matrix, int rowIndex);
    static void SortAscending(ref int[,] matrix, int rowIndex)
    {
        for (int i = 0; i < matrix.GetLength(1)-1; i++)
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
                if (matrix[rowIndex, j] > matrix[rowIndex, j + 1])
                {
                    int t = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                    matrix[rowIndex, j + 1] = t;
                }
    }
    static void SortDescending(ref int[,] matrix, int rowIndex)
    {
        for (int i = 0; i < matrix.GetLength(1)-1; i++)
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
                if (matrix[rowIndex, j] < matrix[rowIndex, j + 1])
                {
                    int temp = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                    matrix[rowIndex, j + 1] = temp;
                }
    }

    public void Task_3_2(int[,] matrix)
    {
        SortRowStyle sortStyle = default(SortRowStyle);
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                sortStyle = SortAscending;
            }
            else
            {
                sortStyle = SortDescending;
            }
            sortStyle(ref matrix, i);
        }

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
        // create and use methods SwapRight(array) and SwapLeft(array)
        // create and use method GetSum(array, start, h) that sum elements with a negative indexes
        // change method in variable swapper in the if/else and than use swapper(matrix)

        // end

        return answer;
    }

    public delegate int[] GetTriangle(int[,] matrix);
    static int[] GetUpperTriange(int[,] matrix)
    {
        int k = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i <= j) k++;
            }
        }
        int[] array = new int[k];
        int array_index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i <= j)
                {
                    array[array_index] = matrix[i, j];
                    array_index++;
                }
            }
        }
        return array;
    }
    static int[] GetLowerTriange(int[,] matrix)
    {
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i >= j) k++;
            }
        }
        int[] array = new int[k];
        int array_index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i >= j)
                {
                    array[array_index] = matrix[i, j];
                    array_index++;
                }
            }
        }
        return array;
    }

    static int GetSum(GetTriangle triangleDelegate, int[,] matrix)
    {
        int s = 0;
        int[] array = triangleDelegate(matrix);
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i] * array[i];
        }
        return s;
    }
    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here
        GetTriangle triangleDelegate;

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)
        if (isUpperTriangle) triangleDelegate = GetUpperTriange;
        else triangleDelegate = GetLowerTriange;
        
        // end
        answer = GetSum(triangleDelegate, matrix);
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

    public delegate int FindElementDelegate(int[,] matrix);
    static int FindDiagonalMaxIndex1(int[,] matrix)
    {
        int max_el = int.MinValue;
        int max_el_index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > max_el)
            {
                max_el = matrix[i, i];
                max_el_index = i;
            }
        }
        return max_el_index;
    }
    static int FindFirstRowMaxIndex(int[,] matrix)
    {
        int max_el = int.MinValue;
        int max_el_index = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[0, j] > max_el)
            {
                max_el= matrix[0, j];
                max_el_index = j;
            }
        }
        return max_el_index;
    }
    static int[,] SwapColumns(int[,] matrix, FindElementDelegate d, FindElementDelegate s)
    {
        int index_d = d(matrix);
        int index_s = s(matrix);
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = matrix[i, index_s];
            matrix[i, index_s] = matrix[i, index_d];
            matrix[i, index_d] = temp;

        }
        return matrix;
    }
    public void Task_3_6(int[,] matrix)
    {
        // code here
        FindElementDelegate diagonal_delegate = FindDiagonalMaxIndex1;
        FindElementDelegate stroka_delegate = FindFirstRowMaxIndex;
        matrix = SwapColumns(matrix, diagonal_delegate, stroka_delegate);

        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
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
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

        // end
    }

    public delegate int FindIndex(int[,] matrix);
    static int FindMaxBelowDiagonalIndex(int[,] matrix)
    {
        int max_el = int.MinValue;
        int max_el_index = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j=0;j<matrix.GetLength(1); j++)
            {
                if (i >= j)
                {
                    if (matrix[i, j] > max_el)
                    {
                        max_el = matrix[i, j];
                        max_el_index = j;
                    }
                }
            }
        }
        return max_el_index;
    }
    static int FindMinAboveDiagonalIndex(int[,] matrix)
    {
        int min_el = int.MaxValue;
        int min_el_index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i < j)
                {
                    if (matrix[i, j] < min_el)
                    {
                        min_el = matrix[i, j];
                        min_el_index = j;
                    }
                }
            }
        }
        return min_el_index;
    }

    static int[,] RemoveColumn1(int[,] matrix, int columnIndex)
    {
        int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        int index = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != columnIndex)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    answer[i, index] = matrix[i, j];
                }
                index++;
            }
        }

        return answer;
    }
    static int[,] RemoveColumns(int[,] matrix, FindIndex max_delegate, FindIndex min_delegate) 
    {
        int max = max_delegate(matrix);
        int min = min_delegate(matrix);
        if (max > min)
        {
            matrix = RemoveColumn1(matrix, max);
            matrix = RemoveColumn1(matrix, min);
        } else if(min > max)
        {
            matrix = RemoveColumn1(matrix, min);
            matrix = RemoveColumn1(matrix, max);
        } else matrix = RemoveColumn1(matrix, max);
        return matrix;
    }
    public void Task_3_10(ref int[,] matrix)
    {
        //FindIndex searchArea = default(FindIndex);

        FindIndex max_delegate = FindMaxBelowDiagonalIndex;
        FindIndex min_delegate = FindMinAboveDiagonalIndex;

        matrix = RemoveColumns(matrix,max_delegate,min_delegate);
        
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

    public delegate int GetNegativeArray(int[,] matrix, int index);
    static int GetNegativeCountPerRow(int[,] matrix, int rowIndex)
    {
        int k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowIndex, j] < 0) k++;
        }
        return k;
    }
    static int GetMaxNegativePerColumn(int[,] matrix, int index)
    {
        int k = Int32.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, index] < 0 && matrix[i, index] > k)
            {
                k = matrix[i, index];
            }
        }
        return k;
    }
    static void FindNegatives(int[,] matrix, GetNegativeArray kolvo, GetNegativeArray max, out int[] rows, out int[] cols)
    {
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            rows[i] = kolvo(matrix, i);
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            cols[j] = max(matrix, j);
        }
    }
    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        GetNegativeArray kolvo = GetNegativeCountPerRow;
        GetNegativeArray max = GetMaxNegativePerColumn;

        FindNegatives(matrix, kolvo, max, out rows, out cols);

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

    public delegate bool IsSequence(int[] array, int left, int right);
    static bool FindIncreasingSequence(int[] array, int A,int B)
    {
        for (int i = A; i <= B - 1; i++)
        {
            if (array[i + 1] < array[i])
            {
                return false;
            }
        }
        return true;
    }
    static bool FindDecreasingSequence(int[] array, int A, int B)
    {
        for (int i = A; i <= B - 1; i++)
        {
            if (array[i + 1] > array[i])
            {
                return false;
            }
        }
        return true;
    }
    static int DefineSequence(int[] array, IsSequence IncreasingDelegate, IsSequence DecreasingDelegate)
    {
        bool incr = IncreasingDelegate(array, 0, array.Length - 1);
        bool decr = DecreasingDelegate(array, 0, array.Length - 1);
        if (incr) return 1;
        else if (decr) return -1;
        else return 0;
    }
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        IsSequence IncreasingDelegate = FindIncreasingSequence;
        IsSequence DecreasingDelegate = FindDecreasingSequence;

        answerFirst = DefineSequence(first, IncreasingDelegate, DecreasingDelegate);
        answerSecond = DefineSequence(second, IncreasingDelegate, DecreasingDelegate);
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }
    static int[] FindLongestSequence(int[] array, IsSequence s)
    {
        int[] newar = new int[2];
        int dlina = -1000;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j <= array.Length - 1; j++)
            {
                if (s(array, i, j)==true)
                {
                    if (j - i> dlina)
                    {
                        dlina = j - i;
                        newar[0] = i;
                        newar[1] = j;
                    }
                }

            }
        }
        return newar;
    }
    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here

        IsSequence IncreasingDelegate = FindIncreasingSequence;
        IsSequence DecreasingDelegate = FindDecreasingSequence;

        answerFirstIncrease = FindLongestSequence(first, IncreasingDelegate);
        answerFirstDecrease = FindLongestSequence(first, DecreasingDelegate);
        answerSecondIncrease = FindLongestSequence(second, IncreasingDelegate);
        answerSecondDecrease = FindLongestSequence(second, DecreasingDelegate);
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);

        // end
    }
    #endregion
    #region bonus part
    public delegate double[,] MatrixConverter(double[,] matrix);

    static double[,] ToUpperTriangular(double[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int j = 0; j < n - 1; j++)
        {
            for (int k = j + 1; k < n; k++)
            {
                double p = matrix[k, j] / matrix[j, j];

                // Обнуление элементов ниже главной диагонали
                for (int m = j; m < n; m++)
                {
                    matrix[k, m] -= matrix[j, m] * p;
                }
            }
        }
        return matrix;
    }
    static double[,] ToLowerTriangular(double[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int j = n - 1; j >= 0; j--)
        {
            for (int k = j - 1; k >= 0; k--)
            {
                double p = matrix[k, j] / matrix[j, j];
                // Обнуление элементов выше главной диагонали
                for (int m = 0; m <= n - 1; m++)
                {
                    matrix[k, m] = matrix[k, m] - (matrix[j, m] * p);
                }
            }
        }
        return matrix;
    }
    static double[,] ToLeftDiagonal(double[,] matrix)
    {
        return ToLowerTriangular(ToUpperTriangular(matrix));
    }
    static double[,] ToRightDiagonal(double[,] matrix)
    {
        return ToUpperTriangular(ToLowerTriangular(matrix));
    }
    public double[,] Task_4(double[,] matrix, int index)
    {
        MatrixConverter[] mc = new MatrixConverter[4];
        mc[0] = ToUpperTriangular;
        mc[1] = ToLowerTriangular;
        mc[2] = ToLeftDiagonal;

        
        if (index == 0) matrix = mc[0](matrix);
        else if (index == 1) matrix = mc[1](matrix);
        else if (index == 2) matrix = mc[2](matrix);
        else if (index == 3) matrix = mc[3](matrix);
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
