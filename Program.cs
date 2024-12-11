// пробный 1

using System;
using System.Reflection;

namespace CW2_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            //var array = new int[] { 1, 5, -5, 4, 3, -1, 4, 18, 5, 5, 3, 18, -1, 2, 3 };
            var matrix = new int[,] {
                { 1, 2, 3, 4, 5},
                { 5, 0, 3, 2, 3},
                { 5, 5, 20, 4, 2},
                { 1, 2, 2, 1, 0},
                { 1, 2, 4, 3, 2} };
            //program.Task_4(ref array);
            program.Task_5(ref matrix);
            // Task_1:
            // input:   1 5 -5 4 4 -1 3 -2 5 5 3 -4 -1 2 3
            // output:  1 5 -5 4 4 -1 3 18 5 5 3 18 -1 2 3

            // Task_2:
            // input:   1 5 -5 4 4 -1 3 18 5 5 3 18 -1 2 3
            // output:  1 5 -5 4 3 -1 4 18 5 5 3 18 -1 2 3

            // Task_3:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 3 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            // output:
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 20 4 2
              1 2 2 1 0
              1 2 4 3 2*/

            // Task_4:
            // input:   1 5 -5 4 3 -1 4 18 5 5 3 18 -1 2 3
            // output:  1 5 -5 4 3 -1 4 18 5 5 3 18 -1 13 2 3

            // Task_5:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 20 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            // output:
            /*1 2 2 1 0
            1 2 4 3 2
            5 0 3 2 3
            1 2 3 4 5
            5 5 20 4 2*/

        }
        public void printArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]}  ");
            }
        }
        public void printMatrix(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i,j]}  ");
                }
                Console.WriteLine();
            }
        }
        void Task_1(int[] A)
        {
            // В одномерном массиве найти сумму индексов максимальных элементов. Заменить все четные отрицательные элементы найденной суммой.
            if (A == null || A.Length == 0) return;
            int sum = 0, index_maxi = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= A[index_maxi])
                {
                    index_maxi = i;
                    sum += i;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0 && A[i] < 0)
                {
                    A[i] = sum;
                }
            }
            printArray(A);
        }
        void Task_2(int[] array)
        {
            // В одномерном массиве отсортировать все положительные элементы с четными индексами, расположенные между максимальным
            // и минимальным элементом, по возрастанию. Остальные элементы оставить на своих местах.
            if (array == null || array.Length == 0) return;
            int index_mini = 0, index_maxi = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[index_maxi])
                {
                    index_maxi = i;
                }
                if (array[i] < array[index_mini])
                {
                    index_mini = i;
                }
            }
            int start = Math.Min(index_maxi, index_mini);
            int end = Math.Max(index_maxi, index_mini);
            for (int i = start + 1; i < end; i++)// пузырек
            {
                if (i % 2 == 0 && array[i] > 0)
                {
                    for(int j = i + 1; j < end; j++)
                    {
                        if (j % 2 == 0 && array[j] > 0 && array[j] < array[i])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        } 
                    }                    
                }
            }
            printArray(array);
        }
        void Task_3(int[,] matrix)
        {
            // Дана квадратная матрица A. Найти сумму элементов правого верхнего и левого нижнего квадратов.
            // Квадраты образуются пересечением срединной строки и срединного столбца матрицы.
            // Элементы этих строк и столбцов не считать частью квадратов. Заменить центральный элемент матрицы найденной суммой.
            /*1 2  3 4  5 6
              5 0  3 2  3 7

              5 5  3 4  2 8 
              1 2  2 1  0 9

              1 2  4 3  2 1 
              4 3  2 7  1 3*/
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            if (matrix == null || n == 0 || n != m) return;
            if (n % 2 == 1)
            {
                int suma1 = 0, suma2 = 0;
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = n / 2 + 1; j < m; j++)
                    {
                        suma1 += matrix[i, j];
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                for (int i = n / 2 + 1; i < n; i++)
                {
                    for (int j = 0; j < m / 2; j++)
                    {
                        suma2 += matrix[i, j];
                    }
                }
                matrix[n / 2, m / 2] = suma1 + suma2;
            }
            else
            {
                int suma1 = 0, suma2 = 0;
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    for (int j = n / 2 + 1; j < m ; j++)
                    {
                        suma1 += matrix[i, j];
                        Console.Write(matrix[i, j]);
                    }
                    
                }
                for (int i = n / 2 + 1; i < n; i++)
                {
                    for (int j = 0; j < m / 2 - 1; j++)
                    {
                        suma2 += matrix[i, j];
                        
                    }    
                }
                
                matrix[n / 2, m / 2] = suma1 + suma2;
                matrix[n / 2 - 1, m / 2] = suma1 + suma2;
                matrix[n / 2, m / 2 - 1] = suma1 + suma2;
                matrix[n / 2 - 1, m / 2 - 1] = suma1 + suma2;
            }
            
            printMatrix(matrix);
        }
        

        void Task_4(ref int[] array)
        {
            // В одномерном массиве вставить сумму минимального и максимального элементов после последнего отрицательного элемента.
            // Вставку элемента осуществлять в методе InsertItem(array, item, index). Метод должен возвращать новый массив.
            if (array == null || array.Length == 0) return;
            int n = array.Length, maxi = array[0], mini = array[0], index = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > maxi) maxi = array[i];
                if (array[i] < mini) mini = array[i];
                if (array[i] < 0) index = i;
            }
            int suma = maxi + mini;
            if (index > 0 && index != n - 1)
            {
                array = InsertItem(array, suma, index + 1);
            }
            printArray(array);

        }
        public int[] InsertItem(int[] array, int item, int index)
        {
            if (index < 0 || index >= array.Length) return array;
            int n = array.Length;
            int[] B = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (i < index)
                {
                    B[i] = array[i];
                }
                else
                {
                    B[i + 1] = array[i];
                }
            }
            B[index] = item;
            array = B;
            return array;
        }
        void Task_5(ref int[,] matrix)
        {
            // Отсортировать строки матрицы А по возрастанию сумм положительных элементов.
            // Суммирование положительных элементов в строках оформить методом SumRow(matrix, row).
            // Метод должен возвращать целое число. Сортировку строк оформить методом SortByPatternAscending(matrix, pattern).
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            int[] sum = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum[i] = SumRow(matrix, i);
            }
            SortByPatternAscending(matrix, sum);
            printMatrix(matrix);
        }
        public int SumRow(int[,] matrix, int row)
        {
            int suma = 0;
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int j = 0; j < m; j++)
            {
                if (matrix[row, j] > 0) suma += matrix[row, j];
            }
            return suma;
        }
        public int[,] SortByPatternAscending(int[,] matrix, int[] pattern)
        {
            for (int i = 0; i < pattern.Length; i++)// пузырек
            {
                for (int j = i + 1; j < pattern.Length; j++)
                {
                    if (pattern[i] > pattern[j])
                    {
                        int t = pattern[i];
                        pattern[i] = pattern[j];
                        pattern[j] = t;
                        for (int k = 0; k < matrix.GetLength(1); k++)
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[j, k];
                            matrix[j, k] = temp;
                        }
                    }
                }
            }
            return matrix;
        }

    }
}




// пробный 2 вариант

using System;
using System.Data.Common;
using System.Reflection;

namespace CW2_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var array = new int[] { 1, 5, 4, 4, 2, -1, 3, -2, 5, 5, -3, -4, -1, -5, 3 };
            var matrix = new int[,] {
                { 1, 2, 3, 4, 5},
                { 5, 0, 3, 2, 3},
                { 5, 5, 3, 4, 2},
                { 1, 2, 2, 1, 0},
                { 1, 2, 4, 3, 2}
            };
            //program.Task_4(ref array);
            program.Task_3(matrix);
            //program.Task_5(ref matrix);


            // Task_1:
            // input:   1 5 -5 -4 4 -1 3 -2 5 5 -3 4 -1 2 3
            // output:  1 5 2 -4 4 -1 3 -2 5 5 -3 4 -1 -5 3

            // Task_2:
            // input:   1 5 2 -4 4 -1 3 -2 5 5 -3 4 -1 -5 3
            // output:  1 5 4 4 2 -1 3 -2 5 5 -3 -4 -1 -5 3

            // Task_3:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 3 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            // output:
            /*1 5 3 1 5
              5 2 3 3 3
              5 0 3 4 2
              1 2 2 2 0
              1 2 4 4 2*/

            // Task_4:
            // input:   1 5 4 4 2 -1 3 -2 5 5 -3 -4 -1 -5 3
            // output:  1 5 4 4 2 -1 3 -2 5 5 -4 -1 -5 3

            // Task_5:
            // input: 
            /*1 5 3 1 5
              5 2 3 3 3
              5 0 3 4 2
              1 2 2 2 0
              1 2 4 4 2*/
            // output:
            /*1 5 3 1 5
              1 2 3 3 3
              1 0 3 4 2
              1 2 3 2 2
              5 2 2 2 0
              5 2 4 4 2*/
        }
        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public void printMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        void Task_1(int[] array)
        {
            // В одномерном массиве поменять местами первый отрицательный элемент и минимальный элемент,
            // расположенный после последнего отрицательного элемента.
            if (array == null || array.Length == 0) return;
            int index_first = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index_first = i;
                    break;
                }
            }
            int index_last = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index_last = i;
                }
            }
            int index_mini = index_last + 1;
            for (int i = index_last + 1; i < array.Length; i++)
            {
                if (array[i] < array[index_mini])
                {
                    index_mini = i;
                }
            }
            if (index_first != -1 && index_last != array.Length - 1)
            {
                int t = array[index_mini];
                array[index_mini] = array[index_first];
                array[index_first] = t;
            }
            printArray(array);

        }
        void Task_2(int[] array)
        {
            // В одномерном массиве отсортировать все четные элементы по убыванию, оставив нечетные на своих местах.
            if (array == null || array.Length == 0) return;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] % 2 == 0 && array[i] < array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
            printArray(array);
        }
        void Task_3(int[,] matrix)
        {
            // Дана матрица А. Сдвинуть четные элементы каждого столбца вниз после нечетных с сохранением их порядка. 
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            if (matrix == null || n == 0 || m == 0 || n != m) return;
            printMatrix(matrix);
            Console.WriteLine();
            for(int j = 0; j < m; j ++)
            {
                int[] t = new int[n];
                int index = 0;
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        t[index] = matrix[i, j];
                        index++;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        t[index] = matrix[i, j];
                        index++;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    matrix[i, j] = t[i];
                }
            }
            //for (int j = 0; j < m; j++)
            //{
            //    for (int i = 0; i < n - 1; )
            //    {
            //        if (i >= 0 && matrix[i, j] % 2 == 0 && matrix[i + 1, j] % 2 == 1)
            //        {
            //            int t = matrix[i, j];
            //            matrix[i, j] = matrix[i + 1, j];
            //            matrix[i + 1, j] = t;
            //            i--;
            //        }
            //        else
            //        {
            //            i++;
            //        }
            //    }
            //}
            Console.WriteLine( );
            printMatrix(matrix);
        }
        void Task_4(ref int[] array)
        {
            // В одномерном массиве удалить все отрицательные элементы, расположенные сразу после максимального элемента.
            // Удаление элемента осуществлять в методе DeleteItem(array, index).
            if (array == null || array.Length == 0) return;
            int index_maxi = 0, maxi = array[0];
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > maxi) 
                {
                    maxi = array[i];
                    index_maxi = i;
                }
            }
            //if (array[index_maxi + 1] < 0) DeleteItem(ref array , index_maxi + 1);
            for (int i = index_maxi + 1; i < n - 1; i++)
            {
                if (array[i - 1] == maxi && array[i] < 0) array = DeleteItem(array , i);
            }
            printArray(array);

        }

        public int[] DeleteItem(int[] array, int index)
        {
            int n = array.Length;
            if (index < 0 || index >= n) return array;
            int[] A = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                if (i < index) A[i] = array[i];
                else A[i] = array[i + 1];
            }
            array = A;
            return array;
        }
        void Task_5(ref int[,] matrix)
        {
            printMatrix(matrix);
            Console.WriteLine( );
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            if (matrix == null || n == 0 || m == 0 || n != m) return;
            // В матрице А отсортировать по возрастанию элементы первого по счету столбца.
            // Вставить в матрицу вектор Е, состоящий из элементов главной диагонали, в качестве новой строки с сохранением упорядоченности
            // элементов первого столбца. Сортировку первого столбца в матрице оформить методом SortColumnAscending(matrix, column).
            // Вставку вектора оформить методом InsertRow(matrix, array).
            matrix = SortColumnAscending(matrix, 0);
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = matrix[i,i];
            }
            matrix = InsertRow(matrix, t);
            printMatrix(matrix);
        }
        public int[,] InsertRow(int[,] matrix,int[] array)
        {
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[,] A = new int[n + 1, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, 0] <= array[0])
                {
                    index++;
                    for (int j = 0; j < m; j++)
                    {
                        A[i, j] = matrix[i, j];
                    }

                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        A[i + 1, j] = matrix[i, j];
                    }
                }

            }
            for (int j = 0; j < m; j++)
            {
                A[index, j] = array[j];
            }
            matrix = A;
            return matrix;
        }
        public int[,] SortColumnAscending(int[,] matrix, int column)
        {
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    if (matrix[i, column] > matrix[k, column])
                    {
                        int t = matrix[i, column];
                        matrix[i, column] = matrix[k, column];
                        matrix[k, column] = t;
                    }
                }
            }
            return matrix;
        }
    }
}




// вариант 1

using System;
using System.Reflection;

namespace CW2_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var array = new int[] { 119, 5, -5, 4, 4, -100, 3, 18, 51, 5, 3, 18, -14, 2, 3 };
            var matrix = new int[,]
            {
                { 1, 2, 3, 4, 5},
                { 5, 0, 3, 2, 3},
                { 5, 5, 3, 4, 2},
                { 1, 2, 2, 1, 0},
                { 1, 2, 4, 3, 2}
            };
            program.Task_5( ref matrix);
        }
        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} " );
            }
        }
        public void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        void Task_1(int[] array)
        {
            if (array == null || array.Length == 0) return;
            printArray(array);
            Console.WriteLine();
            int index_maxi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[index_maxi]) index_maxi = i;
            }
            int suma = 0;
            for (int i = 0; i < index_maxi; i++)
            {
                if (array[i] > 0) suma += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) array[i] = suma; ;
            }            
            printArray(array);
        }
        void Task_2(int[] array)
        {
            if (array == null || array.Length == 0) return;
            printArray(array);
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < 0 && array[i] < array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
            printArray(array);
        }
        void Task_3(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            printMatrix(matrix);
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int index_maxi = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[i, index_maxi])
                    {
                        index_maxi = j;
                    }
                }
                int t = matrix[i, index_maxi];
                matrix[i, index_maxi] = matrix[i, 0];
                matrix[i, 0] = t;
            }
            printMatrix(matrix);
        }
        void Task_4(ref int[] array)
        {
            if (array == null || array.Length == 0) return;
            printArray(array);
            Console.WriteLine();
            int index_maxi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[index_maxi]) index_maxi = i;
            }
            array = DeleteItem(array, index_maxi);
            printArray(array);
        }
        public int[] DeleteItem(int[] array, int index)
        {
            int n = array.Length;
            int[] A = new int[n - 1]; 
            for (int i = 0; i < n - 1; i++)
            {
                if (i < index) A[i] = array[i];
                else A[i] = array[i + 1];
            }
            array = A;
            return array;
        }
        void Task_5(ref int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            printMatrix(matrix);
            Console.WriteLine();
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int index_1 = FindMaxRowIndex(matrix, 0);
            matrix = DeleteRow(matrix, index_1);
            int index_2 = FindMaxRowIndex(matrix, m - 1);
            matrix = DeleteRow(matrix, index_2);
            printMatrix(matrix);
        }
        public int FindMaxRowIndex(int[,] matrix, int column)
        {
            int index_maxi = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, column] > matrix[index_maxi, column])
                {
                    index_maxi = i;
                }
            }
            return index_maxi;
        }
        public int[,] DeleteRow(int[,] matrix, int row)
        {
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[,] A = new int[n - 1, m];
            for(int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < row) A[i, j] = matrix[i, j];
                    else A[i, j] = matrix[i + 1, j];
                }
            }
            matrix = A;
            return matrix;
        }
    }
}



// вариант 2

using System;
using System.Data;
using System.Reflection;

namespace CW2_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var array = new int[] { -6, -2, -7, 0, -3, 1, 2, 3, 4, -1, -2, -3, -4, 4, 1, 0 };
            var matrix = new int[,]
            {
                { 1, 2, 3, 4, 5},
                { 5, 0, 3, 21, 3},
                { 5, 5, 1, 4, 2},
                { 1, 2, 2, 1, 0},
                { 1, 2, 4, 3, 2}
            };
            program.Task_5(ref matrix);
        }
        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} " );
            }
        }
        public void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        void Task_1(int[] array)
        {
            printArray(array);
            Console.WriteLine();
            if (array == null || array.Length == 0) return;
            int index_last = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) index_last = i;
            }
            int index_mini = index_last + 1;
            for (int i = index_last + 1; i < array.Length; i++)
            {
                if (array[i] < array[index_mini]) index_mini = i;
            }
            if (index_last != -1 && index_mini < array.Length)
            {
                int t = array[index_last];
                array[index_last] = array[index_mini];
                array[index_mini] = t;
            }
            printArray(array);
        }
        void Task_2(int[] array)
        {
            printArray(array);
            Console.WriteLine();
            if (array == null || array.Length == 0) return;
            for (int i = 0; i < array.Length ; i++)
            {
                if (array[i] > 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] > 0 && array[i] < array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
            printArray(array);
        }
        void Task_3(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            printMatrix(matrix);
            Console.WriteLine();
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int j = 0; j < m - 1; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    int t = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = t;
                }
            }
            printMatrix(matrix);
        }
        void Task_4(ref int[] array)
        {
            printArray(array);
            Console.WriteLine();
            if (array == null || array.Length == 0) return;
            int index_last = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) index_last = i;
            }
            if (index_last != -1 && index_last + 1 < array.Length)
                array = InsertItem(array, index_last + 1, index_last + 1);
            printArray(array);
        }
        public int[] InsertItem(int[] array, int item, int index)
        {
            int n = array.Length;
            int[] A = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (i < index) A[i] = array[i];
                else A[i + 1] = array[i];
            }
            A[index] = item;
            array = A;
            return array;
        }
        void Task_5(ref int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            printMatrix(matrix);
            Console.WriteLine();
            int row = 0, column = 0;
            FindMax(matrix, out row, out column);
            if (row % 2 == 0)
            {
                for (int j = column + 1; j < matrix.GetLength(0); j++)
                {
                    matrix = SortColumnDescending(matrix, j);
                }
            }
            else
            {
                for (int j = 0; j < column; j++)
                {
                    matrix = SortColumnDescending(matrix, j);
                }
            }
            printMatrix(matrix);
        }
        public void FindMax(int[,] matrix, out int row, out int column)
        {
            row = 0; column = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[row, column])
                    {
                        row = i;
                        column = j; 
                    }
                }
            }
        }
        public int[,] SortColumnDescending(int[,] matrix, int column)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1;  j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, column] < matrix[j, column])
                    {
                        int t = matrix[i, column];
                        matrix[i, column] = matrix[j, column];
                        matrix[j, column] = t;
                    }
                }
            }
            return matrix;
        }
    }
}



// вариант 3

using System;
using System.Reflection;


namespace CW2_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var array = new int[] { 1, 5, -5, -4, 4, -1, 3 };
            var matrix = new int[,]
            {
                { 1, 2, 3, 4, 5},
                { 5, 0, -4, 2, 3},
                { 5, 5, 3, -4, 2},
                { 10, 2, 2, 1, 0},
                { 1, 2, 4, 3, 2}
            };
            program.Task_5(ref matrix);
            // Task_1:
            // input:   1 5 -5 -4 4 -1 3 -2 5 5 -3 4 -1 2 3
            // output:  1 5 2 -4 4 -1 3 -2 5 5 -3 4 -1 -5 3
            // Task_3:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 3 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            // output:
            /*1 5 3 1 5
              5 2 3 3 3
              5 0 3 4 2
              1 2 2 2 0
              1 2 4 4 2*/
        }
        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} " );
            }
        }
        public void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        void Task_1(int[] array)
        {
            if (array == null || array.Length == 0) return;
            printArray(array);
            Console.WriteLine();
            int n = array.Length;
            int index_first = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    index_first = i;
                    break;
                }
            }
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    suma += array[i]; 
                }
            }
            if (index_first != -1)
            {
                for (int i = index_first + 1; i < n; i++)
                {
                    if (array[i] < 0)
                    {
                        array[i] = suma;
                    }
                }
            }
            printArray(array);  

        }
        void Task_2(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int n = array.Length;  
            printArray(array);
            Console.WriteLine();
            if (n % 2 == 1)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = i + 1; j < n / 2; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
                for (int i = n / 2; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    for (int j = i + 1; j < n / 2 - 1; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
                for (int i = n / 2; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
            
            printArray(array);
        }
        void Task_3(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            printMatrix(matrix);
            Console.WriteLine();
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int index_mini_i = 0, index_mini_j = 0;  
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < matrix[index_mini_i, index_mini_j])
                    {
                        index_mini_i = i;
                        index_mini_j = j;
                    }
                }
            }
            for (int j = 0; j < m; j++)
            {
                int t = matrix[index_mini_i, j];
                matrix[index_mini_i, j] = matrix[n - 1, j];
                matrix[n - 1, j] = t;
            }
            printMatrix(matrix);
        }
        void Task_4(ref int[] array)
        {
            if (array == null || array.Length == 0) return;
            int n = array.Length;
            printArray(array);
            Console.WriteLine();
            int index_first = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    index_first = i;
                    break;
                }
            }
            if (index_first != -1) array = DeleteItem(array, index_first);
            printArray(array);
        }
        public int[] DeleteItem(int[] array, int index)
        {
            int n = array.Length;
            int[] A = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                if (i < index) A[i] = array[i];
                else A[i] = array[i + 1];
            }
            array = A;
            return array;
        }
        void Task_5(ref int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            printMatrix(matrix);
            Console.WriteLine();
            int row, column;
            FindMax(matrix, out row, out column);
            if (column % 2 != 0)
            {
                for (int i = row + 1; i < n; i++)
                {
                    matrix = SortRowAscending(matrix, i);
                }
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    matrix = SortRowAscending(matrix, i);
                }
            }
            printMatrix(matrix);
        }
        public void FindMax(int[,] matrix, out int row, out int column)
        {
            row = 0; column = 0;
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > matrix[row, column])
                    {
                        row = i;
                        column = j;
                    }
                }
            }
        }
        public int[,] SortRowAscending(int[,] matrix, int row)
        {
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int j = 0; j < m; j++)
            {
                for (int k = j + 1; k < m; k++)
                {
                    if (matrix[row, j] > matrix[row, k])
                    {
                        int t = matrix[row, k];
                        matrix[row, k] = matrix[row, j];
                        matrix[row, j] = t;
                    }
                }
            }
            return matrix;
        }
    }
}


// вариант 6
using System;
using System.Reflection;

namespace CW2_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var array = new int[] { 1, 5, - 5, - 4, 4, - 1, 3, 6 };
            var matrix = new int[,]
            {
                { 1, 3, 3, 4, 2},
                { 5, 0, -4, 2, 3},
                { 5, 0, -3, 4, 2},
                { 10, -2, 2, 1, 0},
                { 1, 2, -4, 3, 2}
            };
            program.Task_5(ref matrix);
            // Task_1:
            // input:   1 5 -5 -4 4 -1 3 -2 5 5 -3 4 -1 2 3
            // output:  1 5 2 -4 4 -1 3 -2 5 5 -3 4 -1 -5 3

            // Task_2:
            // input:   1 5 2 -4 4 -1 3 -2 5 5 -3 4 -1 -5 3
            // output:  1 5 4 4 2 -1 3 -2 5 5 -3 -4 -1 -5 3

            // Task_3:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 3 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            // output:
            /*1 5 3 1 5
              5 2 3 3 3
              5 0 3 4 2
              1 2 2 2 0
              1 2 4 4 2*/

            // Task_4:
            // input:   1 5 4 4 2 -1 3 -2 5 5 -3 -4 -1 -5 3
            // output:  1 5 4 4 2 -1 3 -2 5 5 -4 -1 -5 3

            // Task_5:
            // input: 
            /*1 5 3 1 5
              5 2 3 3 3
              5 0 3 4 2
              1 2 2 2 0
              1 2 4 4 2*/
            // output:
            /*1 5 3 1 5
              1 2 3 3 3
              1 0 3 4 2
              1 2 3 2 2
              5 2 2 2 0
              5 2 4 4 2*/
        }
        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        void Task_1(int[] array)
        {
            if (array == null || array.Length == 0) return;
            printArray(array);
            Console.WriteLine();

            int n = array.Length;
            int index_maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > array[index_maxi]) index_maxi = i;
            }
            int suma = 0;
            for (int i = index_maxi + 1; i < n; i++)
            {
                suma += array[i];
            }
            if (n > 2)
            {
                if (n % 2 == 0)
                {
                    array[n / 2 - 1] = suma;
                    array[n / 2] = suma;
                }
                else array[n / 2] = suma;
            }
            
            printArray(array);
        }
        void Task_2(int[] array)
        {
            if (array == null || array.Length == 0) return;
            printArray(array);
            Console.WriteLine();

            int n = array.Length;
            int index_mini = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < array[index_mini]) index_mini = i;
            }
            for (int i = index_mini + 1; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];    
                        array[j] = t;
                    }
                }
            }
            printArray(array);
        }
        void Task_3(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            printMatrix(matrix);
            Console.WriteLine();

            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                int index_maxi = 0;
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > matrix[i, index_maxi]) index_maxi = j;
                }
                int suma = 0;
                for(int j = 0; j < m; j += 2)
                {
                    suma += matrix[i, j];
                }
                matrix[i, index_maxi] = suma;
            }
            printMatrix(matrix);
        }
        void Task_4(ref int[] array)
        {
            if (array == null || array.Length == 0) return;
            printArray(array);
            Console.WriteLine();

            int n = array.Length;
            int index_maxi = 0, maxi = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] > array[index_maxi])
                {
                    index_maxi = i;
                    maxi = array[i];
                }   
            }
            InsertItem( ref array, maxi, index_maxi + 1);
            printArray(array);
        }
        public void InsertItem(ref int[] array, int item,  int index)
        {
            int n = array.Length;
            int[] A = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (i < index) A[i] = array[i];
                else A[i + 1] = array[i];
            }
            A[index] = item;
            array = A;
        }
        void Task_5(ref int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            printMatrix(matrix);
            Console.WriteLine();

            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                int index_mini = FindMinIndexInRow(matrix, i);
                matrix = SortRowAscending(matrix, i, index_mini + 1, m);
            }
            printMatrix(matrix);
        }
        public int FindMinIndexInRow(int[,] matrix, int row)
        {
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int index_mini = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[row, j] < matrix[row, index_mini]) index_mini = j;
            }
            return index_mini;
        }
        public int[,] SortRowAscending(int[,] matrix, int row, int start, int end)
        {
            for (int j = start; j < end; j++)
            {
                for (int k = j + 1; k < end; k++)
                {
                    if (matrix[row, j] > matrix[row, k])
                    {
                        int t = matrix[row, k];
                        matrix[row, k] = matrix[row, j];
                        matrix[row, j] = t;
                    }
                }
            }
            return matrix;
        }
    }
}
