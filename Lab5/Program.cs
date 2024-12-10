using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program {
    public static void Main() {
        Program program = new Program();
        int[,] matrix6x6 = new int[,] {
            { 1,    2,  3,  4,  5,  -1 },
            { 6,    7,  8,  9,  10, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { -1,   -2, -3, -4, -5, -1 },
            { 6,    7,  8,  9,  20, -2 },
            { 1,    3,  3,  1,  5, 5 }};
        int[,] matrix7x4 = new int[,] {
            { 1, 2, 3, 4 },
            { 5, 5, 4, 6 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 },
            { 11, 12, 13, 14 },
            { 6, 5, 8, 0 }};
        int[,] matrix6x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 0, 1, 0, 2, 0 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix5x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
        //program.Task_2_10(ref matrix6x6); 
        //program.Task_2_8(new int[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 }, new int[] { 1, 12, 13, 0, 9, 1, 5, -6, 7, 12, 14 });
        //program.Task_2_20(ref matrix7x4,ref matrix6x5);
        //program.Task_2_28b(new int[] { 1, 2, 13, 4, -5, 6, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7 }, ref matrix6x5, ref matrix6x5);
        program.Task_3_10(ref matrix5x5);
    }

    #region Level 1
    static int Factorial(int n) {
        if (n <= 1) {
            return 1;
        }
        return n * (Factorial(n - 1));
    }

    static int Combinations(int n, int k) {
        return Factorial(n) / (Factorial(k) * (Factorial(n - k)));
    }
    public long Task_1_1(int n, int k) {
        long answer = 0;

        // code here
        if (k == 0 || k > 0 && k == n) {
            return 1;
        }
        if (!(k > 0 && k < n)) {
            return 0;
        }
        // create and use Combinations(n, k);

        // create and use Factorial(n);
        answer = Combinations(n, k);


        // end

        return answer;
    }

    static double GeronArea(double a, double b, double c) {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public int Task_1_2(double[] first, double[] second) {
        int answer = 0;

        // code here
        double a = first[0];
        double b = first[1];
        double c = first[2];

        double a_1 = second[0];
        double b_1 = second[1];
        double c_1 = second[2];

        if (a + b <= c || a + c <= b || c + b <= a || a_1 + b_1 <= c_1 || b_1 + c_1 <= a_1 || c_1 + a_1 <= b_1) {
            return -1;
        }

        if (GeronArea(a, b, c) > GeronArea(a_1, b_1, c_1)) {
            return 1;
        }
        else if (GeronArea(a, b, c) < GeronArea(a_1, b_1, c_1)) {
            return 2;
        }
        else if (GeronArea(a, b, c) == GeronArea(a_1, b_1, c_1)) {
            return 0;
        }


        // create and use GeronArea(a, b, c);

        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }


    static double GetDistance(double v, double a, int t) {
        return v * t + a * t * t / 2;
    }
    public int Task_1_3a(double v1, double a1, double v2, double a2, int time) {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        if (GetDistance(v1, a1, time) > GetDistance(v2, a2, time)) {
            return 1;
        }

        if (GetDistance(v1, a1, time) < GetDistance(v2, a2, time)) {
            return 2;
        }
        else {
            return 0;
        }
        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2) {
        int answer = 0;

        // code here

        // use GetDistance(v, a, t); t - hours
        for (int t = 1; ; t++) {
            if (GetDistance(v1, a1, t) <= GetDistance(v2, a2, t)) {
                return t;
            }
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B) {
        // code here

        // create and use FindMaxIndex(matrix, out row, out column);

        // end
    }
    static int FindMaxIndex(double[] array) {
        int c = 0;
        double max = Double.MinValue;
        for (int i = 0; i < array.Length; i++) {
            if (max < array[i]) {
                max = array[i];
                c = i;
            }
        }
        return c;
    }
    public void Task_2_2(double[] A, double[] B) {
        // code here

        // create and use FindMaxIndex(array);
        // only 1 array have to be changed!
        double sum = 0;
        int v = 0;
        if (FindMaxIndex(A) < FindMaxIndex(B)) {
            for (int i = FindMaxIndex(A) + 1; i < A.Length; i++) {
                sum += A[i];
                v++;
            }
            double sr = sum / (v);
            A[FindMaxIndex(A)] = sr;
        }
        else {
            for (int i = FindMaxIndex(B) + 1; i < B.Length; i++) {
                sum += B[i];
                v++;
            }
            double sr = sum / (v);
            B[FindMaxIndex(B)] = sr;
        }

        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C) {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }
    static int FindDiagonalMaxIndex(int[,] array) {
        int c = 0;
        double max = Double.MinValue;
        for (int i = 0; i < array.GetLength(0); i++) {
            if (max < array[i, i]) {
                max = array[i, i];
                c = i;
            }
        }
        return c;
    }
    public void Task_2_4(int[,] A, int[,] B) {
        // code here
        int[] buf = new int[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++) {
            buf[i] = A[FindDiagonalMaxIndex(A), i];
        }
        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3
        for (int i = 0; i < A.GetLength(0); i++) {
            A[FindDiagonalMaxIndex(A), i] = B[i, FindDiagonalMaxIndex(B)];
        }
        for (int i = 0; i < B.GetLength(0); i++) {
            B[i, FindDiagonalMaxIndex(B)] = buf[i];
        }
        // end
    }

    public void Task_2_5(int[,] A, int[,] B) {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }

    static int[] DeleteElement(int[] array, int index) {
        int[] x = new int[array.Length - 1];
        for (int i = 0; i < x.Length; i++) {
            if (i < index) {
                x[i] = array[i];
            }
            else {
                x[i] = array[i + 1];
            }
        }
        return x;
    }

    static int FindMaxIndex_1(int[] array) {
        int c = 0;
        double max = Double.MinValue;
        for (int i = 0; i < array.Length; i++) {
            if (max < array[i]) {
                max = array[i];
                c = i;
            }
        }
        return c;
    }
    public void Task_2_6(ref int[] A, int[] B) {
        // code here

        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);
        int[] answer = new int[A.Length + B.Length - 2];
        int v = 0;
        for (int i = 0; i < answer.Length; i++) {
            if (i < A.Length - 1) {
                answer[i] = (DeleteElement(A, FindMaxIndex_1(A)))[i];
            }
            else {
                answer[i] = (DeleteElement(B, FindMaxIndex_1(B)))[v];
                v++;
            }
        }
        A = answer;
        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C) {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }

    static int[] SortArrayPart(int[] array, int startIndex) {
        int n = array.Length;
        for (int i = startIndex + 2; i < n; i++) {
            int key = array[i], j = i - 1;
            while (j >= startIndex + 1 && array[j] > key) {
                array[j + 1] = array[j]; j--;
            }
            array[j + 1] = key;
        }
        return array;
    }
    public void Task_2_8(int[] A, int[] B) {
        // code here

        // create and use SortArrayPart(array, startIndex);
        A = SortArrayPart(A, FindMaxIndex_1(A));
        B = SortArrayPart(B, FindMaxIndex_1(B));

        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C) {
        int[] answer = default(int[]);

        // code here

        // create and use SumPositiveElementsInColumns(matrix);

        // end

        return answer;
    }
    static int[,] RemoveColumn(int[,] matrix, int index) {

        int indexM = 0;
        int[,] m = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (j == index)
                continue;
            for (int i = 0; i < matrix.GetLength(0); i++) {
                m[i, indexM] = matrix[i, j];
            }
            indexM++;
        }

        return m;
    }

    static void printMatrix(int[,] matrix) {
        string output = "";
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                output = output + matrix[i, j] + "  ";
            }
            output = output + "\n";
        }
        Console.WriteLine(output);
        Console.WriteLine("-----------");
    }

    public void Task_2_10(ref int[,] matrix) {
        // code here
        int Minup = Int32.MaxValue;
        int up = 0;
        int Maxdown = Int32.MinValue;
        int down = 0;


        for (int i = 1; i < matrix.GetLength(0); i++) {
            for (int j = i + 1; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] < Minup) {
                    Minup = matrix[i, j];
                    up = j;
                }
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j <= i; j++) {
                if (matrix[i, j] > Maxdown) {
                    Maxdown = matrix[i, j];
                    down = j;
                }
            }
        }

        if (down > up) {
            matrix = RemoveColumn(matrix, down);
            matrix = RemoveColumn(matrix, up);
        }
        else if (up > down) {
            matrix = RemoveColumn(matrix, up);
            matrix = RemoveColumn(matrix, down);
        }
        else {
            matrix = RemoveColumn(matrix, down);
        }

        // create and use RemoveColumn(matrix, columnIndex);

        // end
    }

    public void Task_2_11(int[,] A, int[,] B) {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }
    static int FindMaxColumnIndex(int[,] matrix) {
        int c = 0;
        int max = Int32.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] > max) {
                    max = matrix[i, j];
                    c = j;
                }
            }
        }
        return c;
    }

    public void Task_2_12(int[,] A, int[,] B) {
        // code here

        // create and use FindMaxColumnIndex(matrix);
        int[] buff = new int[A.GetLength(0)];
        int m = FindMaxColumnIndex(A);
        int n = FindMaxColumnIndex(B);
        for (int i = 0; i < A.GetLength(0); i++) {
            buff[i] = A[i, m];
        }
        for (int i = 0; i < A.GetLength(0); i++) {
            A[i, m] = B[i, n];
        }
        for (int i = 0; i < B.GetLength(0); i++) {
            B[i, n] = buff[i];
        }
        // end
    }

    public void Task_2_13(ref int[,] matrix) {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    static int[,] SortRow(int[,] matrix, int Index) { 
        int n = matrix.GetLength(1);    
        for (int i = 0; i<n; i++) {
            for (int j = 0; j<n- i- 1; j++){
                if (matrix[Index,j] > matrix[Index,j + 1]) {
                    int temp = matrix[Index,j];
                    matrix[Index,j] = matrix[Index,j + 1];
                    matrix[Index,j + 1] = temp;
                }
            }
        }
        return matrix;
    }
    public void Task_2_14(int[,] matrix) {
        // code here

        // create and use SortRow(matrix, rowIndex);
        for (int i = 0; i < matrix.GetLength(0); i++) {
            SortRow(matrix, i);
        }
        // end
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C) {
        int answer = 0;

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }
    static int[] SortNegative(int [] array) {
        int n = array.Length;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (array[j] < 0) {
                    int k = j+1;
                    while (k < n-1 && array[k] >= 0 ) {
                        k++;
                    }
                    if (array[k] > 0) {
                        continue;
                    }
                    if (array[j] < array[k]) {
                        int temp = array[j];
                        array[j] = array[k];
                        array[k] = temp;
                    }
                }
            }
        }
        return array;
    }
    public void Task_2_16(int[] A, int[] B) {
        // code here

        // create and use SortNegative(array);
        SortNegative(A);
        SortNegative(B);
        // end
    }

    public void Task_2_17(int[,] A, int[,] B) {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }

    static int[,] SortDiagonal(int[,] matrix) {
        int n = matrix.GetLength(1);
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (matrix[j, j] > matrix[j+1, j + 1]) {
                    int temp = matrix[j, j];
                    matrix[j, j] = matrix[j+1, j + 1];
                    matrix[j+1, j + 1] = temp;
                }
            }
        }
        return matrix;
    }

    public void Task_2_18(int[,] A, int[,] B) {
        // code here

        // create and use SortDiagonal(matrix);
        SortDiagonal(A);
        SortDiagonal(B);
        // end
    }

    public void Task_2_19(ref int[,] matrix) {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }
    


    static void RemoveColumn_1(ref int[,] matrix, int index) {

        int indexM = 0;
        int[,] m = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (j == index )
                continue;
            for (int i = 0; i < matrix.GetLength(0); i++) {
                m[i, indexM] = matrix[i, j];
            }
            indexM++;
        }
        matrix = m;
    }

    public void Task_2_20(ref int[,] A, ref int[,] B) {
        // code here
        //int n = A.GetLength(1);
        for (int j = A.GetLength(1)-1; j >= 0 ; j--) {
            bool flag = true;
            for (int i = 0; i < A.GetLength(0); i++) {
                if (A[i, j] == 0) {
                    flag = false;
                }

            }
            if (flag) {
                RemoveColumn_1(ref A, j);               
               //n = n - 1;
            }
        }

        //int m = B.GetLength(1);
        for (int j = 0; j < B.GetLength(1); j++) {
            bool flag = true;
            for (int i = 0; i < B.GetLength(0); i++) {
                if (B[i, j] == 0) {
                    flag = false;
                }

            }
            if (flag) {
                RemoveColumn_1(ref B, j);
               //m = m - 1;
            }
        }
        // use RemoveColumn(matrix, columnIndex); from 2_10

        // end
    }

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB) {
        answerA = null;
        answerB = null;

        // code here

        // create and use CreateArrayFromMins(matrix);

        // end
    }

    static int CountNegativeInRow(int[,] matrix,int Index) {
        int c = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (matrix[Index,j] < 0) {
                c++;
            }
        }
        return c;
    }

    static int FindMaxNegativePerColumn(int [,] matrix, int Index) {
        int max = Int32.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            if (matrix[i,Index] > max && matrix[i, Index] < 0) {
                max = matrix[i, Index];
            }
        }
        return max;
    }

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols) {
        rows = null;
        cols = null;

        // code here
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(1)];

        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++) {
            rows[i] = CountNegativeInRow(matrix, i);
        }

        for (int j = 0; j < matrix.GetLength(1); j++) {
            cols[j] = FindMaxNegativePerColumn(matrix, j);
        }

        // end
    }

    public void Task_2_23(double[,] A, double[,] B) {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }

    static void FindMaxIndex(int [,] matrix, out int row, out int column) {
        column = 0;
        row = 0;
        int max = Int32.MinValue;
        for (int j = 0; j < matrix.GetLength(1); j++) {
            for (int i = 0; i < matrix.GetLength(0); i++) {
                if (matrix[i, j] > max) {
                    max = matrix[i, j];
                    column = j;
                    row = i;
                }
            }
        }
    }
    

    static int[,] SwapColumnDiagonal(int[,] matrix, int Index) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            int temp = matrix[i, Index];
            matrix[i, Index] = matrix[i, i];
            matrix[i, i] = temp;
        }
        return matrix;
    }

    public void Task_2_24(int[,] A, int[,] B) {
        // code here

        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);
        int r;
        int col;
        FindMaxIndex(A, out r, out col);
        A = SwapColumnDiagonal(A, col);

        FindMaxIndex(B, out r, out col);
        B = SwapColumnDiagonal(B, col);
        // end
    }

    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB) {
        maxA = 0;
        maxB = 0;

        // code here

        // create and use FindRowWithMaxNegativeCount(matrix);
        // in FindRowWithMaxNegativeCount create and use CountNegativeInRow(matrix, rowIndex); like in 2_22

        // end
    }

    /*static int CountNegativeInRow(int[,] matrix, int Index) {
        int c = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (matrix[Index, j] < 0) {
                c++;
            }
        }
        return c;
    }*/

    static int FindRowWithMaxNegativeCount(int[,] matrix) {
        int max = 0;
        int c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            if( max < CountNegativeInRow(matrix,i)) {
                max = CountNegativeInRow(matrix, i);
                c = i;
            }
        }
        return c;
    }
    public void Task_2_26(int[,] A, int[,] B) {
        // code here

        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22
        int m = FindRowWithMaxNegativeCount(A);
        int n = FindRowWithMaxNegativeCount(B);
        for (int j = 0; j < A.GetLength(1); j++) {
            int temp = A[m, j];
            A[m, j] = B[n, j];
            B[n, j] = temp;
        }
        // end
    }

    public void Task_2_27(int[,] A, int[,] B) {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }
    /*static int FindSequence(int[] array, int A, int B) {
        bool flag_1 = false;
        bool flag_0 = false;
        for (int i = A; i < B-1; i++) {
            if (array[i] < array[i + 1] && !(flag_0)) {
                flag_1 = true;
            }
            else if (array[i] > array[i + 1] && !(flag_1)) {
                flag_0 = true;
            }
            else {
                return 0;
            }
        }
        if (flag_1) {
            return 1;
        }
        else {
            return -1;
        }
            
    }*/
    static bool checkUp(int[] arr, int a, int b) {
        for (int i = a; i <= b - 1; i++) {
            if (arr[i] > arr[i + 1])
                return false;
        }
        return true;
    }

    static bool checkDown(int[] arr, int a, int b) {
        for (int i = a; i <= b - 1; i++) {
            if (arr[i] < arr[i + 1])
                return false;
        }
        return true;
    }

    static int FindSequence(int[] array, int A, int B) {
        if (checkUp(array, A, B))
            return 1;
        if (checkDown(array, A, B))
            return -1;
        return 0;
    }

    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond) {
        // code here

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
        // A and B - start and end indexes of elements from array for search
        answerFirst  = FindSequence(first, 0, first.Length-1);
        answerSecond = FindSequence(second, 0, second.Length - 1);

        // end
    }

    /*static int FindSequence_1(int[] array, int A, int B) {
        bool flag_1 = false;
        bool flag_0 = false;
        int c = 0;
        for (int i = 0; i < array.Length - 1; i++) {
            for (int j = i+1; j < array.Length; j++) {
                if (array[i] < array[j] && !(flag_0)) {
                    c++;
                    flag_1 = true;
                }
                else if (array[i] > array[j] && !(flag_1)) {
                    c++;
                    flag_0 = true;
                }
            }
        }
        return c;
    }*/

    static int[,] FindSequences(int[] array, int A, int B) {
        int c = 0;
        for (int i = A; i <= B - 1; i++) {
            for (int j = i + 1; j <= B; j++) {
                if (FindSequence(array, i, j) != 0)
                    c++;
            }
        }
        int[,] x = new int[c, 2];
        int Index = 0;
        for (int i = A; i <= B - 1; i++) {
            for (int j = i + 1; j <= B; j++) {
                if (FindSequence(array, i, j) != 0) {
                    x[Index, 0] = i;
                    x[Index, 1] = j;
                    Index++;
                }   
            }
        }
        return x;
    }

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond) {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search        
        answerFirst = FindSequences(first, 0, first.Length - 1);
        answerSecond = FindSequences(second, 0, second.Length - 1);

        // end
    }

    static int[] FindMaxSequence(int[,]array) {
        int maxr = 0;
        int[] max = new int[2];
        for (int i = 0; i < array.GetLength(0); i++) {
            if (array[i,1] - array[i,0] > maxr) {
                maxr = array[i, 1] - array[i, 0];
                max[0] = array[i, 0];
                max[1] = array[i, 1];
            }   
          
        }
        return max;
    }

    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond) {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search
        int[,] c = FindSequences(first, 0, first.Length - 1);
        answerFirst = FindMaxSequence(c);
        int[,] n = FindSequences(second, 0, second.Length - 1);
        answerSecond = FindMaxSequence(n);
        // end
    }
    #endregion

    #region Level 3
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY) {
        // code here

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x

        // end
    }

    public delegate void SortRowStyle(ref int[,] matrix,int Index);

    static void SortAscending(ref int[,] matrix, int Index) {
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
                if (matrix[Index, j] > matrix[Index, j + 1]) {
                    int temp = matrix[Index, j];
                    matrix[Index, j] = matrix[Index, j + 1];
                    matrix[Index, j + 1] = temp;
                }
    }

    static void SortDescending(ref int[,] matrix, int Index) {
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
                if (matrix[Index, j] < matrix[Index, j + 1]) {
                    int temp = matrix[Index, j];
                    matrix[Index, j] = matrix[Index, j + 1];
                    matrix[Index, j + 1] = temp;
                }
    }

    public void Task_3_2(int[,] matrix) {
        SortRowStyle sortStyle = default(SortRowStyle);
        // code here
      
        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting
        for (int i = 0; i < matrix.GetLength(0); i++) {
            if (i % 2 == 0) {
                sortStyle = SortAscending;
            }
            else {
                sortStyle = SortDescending;
            }
            sortStyle(ref matrix,i);
        }
        // end

    }

        public double Task_3_3(double[] array) {
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
    public delegate int[] GetTriangle(int[,]matrix) ;
    
    static int[] GetUpperTriange(int[,] matrix) {
        int n = matrix.GetLength(0);
        int[] array = new int[(n*n - n)/2 + n];
        int c = 0;
        for (int i = 0; i < n; i++) {
            for (int j = i; j < matrix.GetLength(1); j++) {
                array[c] = matrix[i,j];
                c++;
            }
        }
        return array;
    }

    static int[] GetLowerTriange(int[,] matrix) {
        int n = matrix.GetLength(0);
        int[] array = new int[(n * n - n) / 2 + n];
        int c = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <= i; j++) {
                array[c] = matrix[i, j];
                c++;
            }
        }
        return array;
    }

    static int GetSum(GetTriangle a, int[,] matrix) {
        int sum = 0;
        int[] array = a(matrix);
        for (int i = 0; i < array.Length; i++) {
            sum += array[i] * array[i];
        }
        return sum;
    }

    public int Task_3_4(int[,] matrix, bool isUpperTriangle) {
        int answer = 0;
        GetTriangle GetT;
        if (isUpperTriangle) {
            GetT = GetUpperTriange;
        }
        else {
            GetT = GetLowerTriange;
        }
        answer = GetSum(GetT, matrix);

        // code here

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)
        
        // end

        return answer;
    }

    public void Task_3_5(out int func1, out int func2) {
        func1 = 0;
        func2 = 0;

        // code here

        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
    }

    public delegate int FindElementDelegate(int[,] matrix);

    static int FindDiagonalMaxIndex_1(int[,]matrix) {
        int c = 0;
        double max = Double.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            if (max < matrix[i, i]) {
                max = matrix[i, i];
                c = i;
            }
        }
        return c;        
    }

    static int FindFirstRowMaxIndex(int[,] matrix) {
        int c = 0;
        double max = Double.MinValue;
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (max < matrix[0, j]) {
                max = matrix[0, j];
                c = j;
            }
        }
        return c;
    }

    static void SwapColumns(ref int[,] matrix, FindElementDelegate a, FindElementDelegate b) {
        int x = a(matrix);
        int y = b(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++) {
            int temp = matrix[i, x];
            matrix[i, x] = matrix[i, y];
            matrix[i, y] = temp;
        }
    }
    public void Task_3_6(int[,] matrix) {
        // code here
        FindElementDelegate Find;
        FindElementDelegate Find_1;
        Find = FindDiagonalMaxIndex_1;
        Find_1 = FindFirstRowMaxIndex;

        SwapColumns(ref matrix,Find,Find_1);
        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        // end
    }

    public void Task_3_7(ref int[,] B, int[,] C) {
        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

        // end
    }
    public delegate int FindIndex(int[,]matrix);

    static int FindMaxBelowDiagonalIndex(int[,] matrix) {
        int down = 0;
        int Maxdown = Int32.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j <= i; j++) {
                if (matrix[i, j] > Maxdown) {
                    Maxdown = matrix[i, j];
                    down = j;
                }
            }
        }
        return down;
    }

    static int FindMinAboveDiagonalIndex(int[,] matrix) {
        int up = 0;
        int Minup = Int32.MaxValue;
        for (int i = 1; i < matrix.GetLength(0); i++) {
            for (int j = i + 1; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] < Minup) {
                    Minup = matrix[i, j];
                    up = j;
                }
            }
        }
        return up;
    }

    static int[,] RemoveColumn_1(int[,] matrix,int Index) {
        int indexM = 0;
        int[,] m = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (j == Index)
                continue;
            for (int i = 0; i < matrix.GetLength(0); i++) {
                m[i, indexM] = matrix[i, j];
            }
        indexM++;
        }

    return m;
    }

    static int[,] RemoveColumns(int[,]matrix, FindIndex Finddown, FindIndex Findup){
        int down = Finddown(matrix);
        int up = Findup(matrix);
        if (down > up) {
            matrix = RemoveColumn_1(matrix, down);
            matrix = RemoveColumn_1(matrix, up);
        }
        else if (up > down) {
            matrix = RemoveColumn_1(matrix, up);
            matrix = RemoveColumn_1(matrix, down);
        }
        else {
            matrix = RemoveColumn_1(matrix, down);
        }

        return matrix;
    }


public void Task_3_10(ref int[,] matrix) {
        //FindIndex searchArea = default(FindIndex);
        FindIndex Finddown = default(FindIndex);
        FindIndex Findup = default(FindIndex);
        // code here

        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)
        Finddown = FindMaxBelowDiagonalIndex;
        Findup = FindMinAboveDiagonalIndex;

        matrix = RemoveColumns(matrix, Finddown, Findup);
        /*static void printMatrix(int[,] matrix) {
            string output = "";
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    output = output + matrix[i, j] + "  ";
                }
                output = output + "\n";
            }
            Console.WriteLine(output);
            Console.WriteLine("-----------");
        }
        printMatrix(matrix);*/
        // end
    }

    public void Task_3_13(ref int[,] matrix) {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }


    public delegate int GetNegativeArray(int[,] matrix, int Index);

    static int GetNegativeCountPerRow(int[,] matrix, int Index) {
        int c = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (matrix[Index, j] < 0) {
                c++;
            }
        }
        return c;
    }

    static int GetMaxNegativePerColumn(int[,] matrix, int Index) {
        int max = Int32.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            if (matrix[i, Index] > max && matrix[i, Index] < 0) {
                max = matrix[i, Index];
            }
        }
        return max;
    }

    static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols) {
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++) {
            rows[i] = searcherRows(matrix, i);
        }

        for (int j = 0; j < matrix.GetLength(1); j++) {
            cols[j] = searcherCols(matrix, j);
        }
    }
    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols) {

        rows = null;
        cols = null;

        // code here
        GetNegativeArray searcherRows;
        GetNegativeArray searcherCols;
        searcherRows = GetNegativeCountPerRow;
        searcherCols = GetMaxNegativePerColumn;

        FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        // end
    }


        public void Task_3_27(int[,] A, int[,] B) {
        // code here

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }



    public delegate bool IsSequence(int[] array, int left, int right);

    static bool FindIncreasingSequence(int[] arr, int a, int b) {
        for (int i = a; i <= b - 1; i++) {
            if (arr[i] > arr[i + 1])
                return false;
        }
        return true;
    }

    static bool FindDecreasingSequence(int[] arr, int a, int b) {
        for (int i = a; i <= b - 1; i++) {
            if (arr[i] < arr[i + 1])
                return false;
        }
        return true;
    }

    static int DefineSequence(int[] array, IsSequence findIncreasingSequence, IsSequence findDecreasingSequence) {
        if (findIncreasingSequence(array, 0, array.Length -1)) {
            return 1;
        }
        if(findDecreasingSequence(array, 0, array.Length - 1)) {
            return -1;
        }
        else {
            return 0;
        }
    }
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond) {
        // code here
        IsSequence findIncreasingSequence;
        IsSequence findDecreasingSequence;

        findIncreasingSequence = FindIncreasingSequence;
        findDecreasingSequence = FindDecreasingSequence;
        answerFirst = DefineSequence(first, findIncreasingSequence, findDecreasingSequence);
        answerSecond = DefineSequence(second, findIncreasingSequence, findDecreasingSequence);
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }


    static int[] FindLongestSequence(int[]array, IsSequence sequence) {
        int[] max = new int[2];
        int maxk = Int32.MinValue;
        for (int i = 0; i < array.Length - 1; i++) {
            for (int j = i + 1; j <= array.Length-1; j++) {
                if (sequence(array, i, j)) {
                    if (maxk < j-i) {
                        maxk = j - i;
                        max[0] = i;
                        max[1] = j;
                    }
                }
                    
            }
        }
        return max;
    }
    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease) {
        // code here
        IsSequence findIncreasingSequence;
        IsSequence findDecreasingSequence;

        findIncreasingSequence = FindIncreasingSequence;
        findDecreasingSequence = FindDecreasingSequence;
        
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);
        answerFirstIncrease = FindLongestSequence(first, findIncreasingSequence);
        answerFirstDecrease = FindLongestSequence(first, findDecreasingSequence);

        answerSecondIncrease = FindLongestSequence(second, findIncreasingSequence);
        answerSecondDecrease = FindLongestSequence(second, findDecreasingSequence);
        // end


        
    }
    #endregion
    #region bonus part

    public double[,] ToUpperTriangular(double[,] a) {
        int n = a.GetLength(0);
        for (int j = 0; j <= n - 2; j++) {
            for (int k = j + 1; k <= n - 1; k++) {
                double p = a[k, j] / a[j, j];
                for (int m = j; m <= n - 1; m++) {
                    a[k, m] = a[k, m] - (a[j, m] * p);
                }
            }
        }
        return a;
    }

    public double[,] ToLowerTriangular(double[,] a) {
        int n = a.GetLength(0);
        for (int j = n - 1; j >= 0; j--) {
            for (int k = j - 1; k >= 0; k--) {
                double p = a[k, j] / a[j, j];
                for (int m = 0; m <= n - 1; m++) {
                    a[k, m] = a[k, m] - (a[j, m] * p);
                }
            }
        }
        return a;
    }

    public double[,] ToLeftDiagonal(double[,] matrix) {
        matrix = this.ToUpperTriangular(matrix);
        matrix = this.ToLowerTriangular(matrix);
        return matrix;
    }

    public double[,] ToRightDiagonal(double[,] matrix) {
        matrix = this.ToLowerTriangular(matrix);
        matrix = this.ToUpperTriangular(matrix);
        return matrix;
    }


    public delegate double[,] MatrixConverter(double[,] matrix);

    public double[,] Task_4(double[,] matrix, int index) {
        // MatrixConverter[] mc = new MatrixConverter[4]; - uncomment me

        // code here

        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle

        // end
        MatrixConverter[] mc = new MatrixConverter[4];
        mc[0] = new MatrixConverter(ToUpperTriangular);
        mc[1] = new MatrixConverter(ToLowerTriangular);
        mc[2] = new MatrixConverter(ToLeftDiagonal);
        mc[3] = new MatrixConverter(ToRightDiagonal);
        matrix = mc[index](matrix);             

        return matrix;
    }
    #endregion
}