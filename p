using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // линейный поиск

            //double[] array = new double[5] { 1, -4, 90, 3, 7 };
            //double target = -4;
            //int n = array.Length, index = -1;
            //for (int i = 0; i < n; i++)
            //{
            //    if (array[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //    Console.WriteLine($"{i}, {index}");
            //}
            //Console.WriteLine(index);


            //бинарный поиск

            //double[] array = new double[5] { -4, 1, 3, 7, 90 };
            //double target = 7;
            //int n = array.Length, index = -1;
            //int left = 0, right = n - 1;
            //while(left <= right)
            //{
            //    int mid = (left + right) / 2;
            //    if (array[mid] == target)
            //    {
            //        index = mid;
            //        break;
            //    }
            //    else if (target > array[mid])
            //    {
            //        left = mid + 1;
            //    }
            //    else
            //    {
            //        right = mid - 1;
            //    }
            //}
            //Console.WriteLine(index);


            // разворот массива

            //double[] array = new double[5] { 1, 2, 3, 4, 5 };
            //int n = array.Length;
            //double t;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    t = array[i];
            //    array[i] = array[n - i - 1];
            //    array[n - i - 1] = t;
            //}
            //foreach(double x in array)
            //{
            //    Console.Write(x);
            //}


            // слияние массивов

            //double[] a = new double[] { 1, 3, 5, 7, 9 }, b = new double[] {2, 4, 6, 8, 10 };
            //int n = a.Length, m = b.Length;
            //double[] c = new double[n + m];
            //int i = 0, j = 0, k = 0;
            //while (i < n && j < m)
            //{
            //    if (a[i] < b[j])
            //    {
            //        c[k] = a[i];
            //        k++;
            //        i++;
            //    }
            //    else
            //    {
            //        c[k] = b[j];
            //        k++;
            //        j++;
            //    }
            //}
            //while (i < n)
            //{
            //    c[k] = a[i];
            //    k++;
            //    i++; 
            //}
            //while (j < m)
            //{
            //    c[k] = b[j];
            //    k++;
            //    j++;
            //}
            //foreach(double x in c)
            //{
            //    Console.Write(x);
            //}


            // циклический сдвиг

            //double[] array = new double[5] { 1, 2, 3, 4, 5 };
            //int n = array.Length, shift = 2;
            //double t;
            //for (int i = 0; i < shift % n; i++)
            //{
            //    t = array[n - 1];
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        array[j] = array[j - 1];

            //    }
            //    array[0] = t;
            //}
            //foreach (double x in array)
            //{
            //    Console.Write(x);
            //}


            //сортировка выбором

            //double[] a = new double[5] { 17, 1.53, -5, 8, -0.21 };
            //int n = a.Length, indexmaxi;
            //double maxi;
            //for (int i = 0; i < n - 1; i++)
            //{
            //    maxi = a[i];
            //    indexmaxi = i;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (a[j] > maxi)
            //        {
            //            maxi = a[j];
            //            indexmaxi = j;
            //        }
            //    }
            //    a[indexmaxi] = a[i];
            //    a[i] = maxi;
            //}
            //foreach (double x in a)
            //{
            //    Console.Write(x);
            //}


            // сортировка пузырьком

            //int[] arr = new int[] { 5, 1, 4, 2, 8 };
            //int n = arr.Length
            //;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n - i - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //        foreach (double x in arr) Console.Write($"{x}  ");
            //    }
            //}


            // гномья сортировка

            //int[] arr = new int[] { 5, 1, 4, 2, 8 };
            //int n = arr.Length;
            //for (int i = 1; i < n;)
            //{


            //    if (i == 0 || arr[i] >= arr[i - 1])
            //        i++;
            //    else
            //    {
            //        int temp = arr[i];
            //        arr[i] = arr[i - 1];
            //        arr[i - 1] = temp;
            //        i--;
            //    }
            //    foreach (double x in arr) Console.Write($"{x}  ");
            //    Console.WriteLine($"i = {i}");

            //}


            //эфективная гномья сортировка

            //int[] arr = new int[] { 5, 1, 4, 2, 8 };
            //int n = arr.Length;
            //for (int i = 1, j = 2; i < n;)
            //{
            //    if (i == 0 || arr[i] >= arr[i - 1])
            //    {
            //        i = j;
            //        j++;
            //    }
            //    else
            //    {
            //        int temp = arr[i];
            //        arr[i] = arr[i - 1];
            //        arr[i - 1] = temp;
            //        i--;
            //    }
            //    foreach (double x in arr) Console.Write($"{x}  ");
            //    Console.WriteLine($"i = {i}, j = {j}");
            //}


            // сортировка вставками

            //int[] arr = new int[] { 5, 1, 4, 2, 8 };
            //int n = arr.Length;
            //for (int i = 1; i < n; i++)
            //{
            //    foreach (double x in arr) Console.Write($"{x}  ");
            //    int key = arr[i], j = i - 1;
            //    while (j >= 0 && arr[j] > key)
            //    {
            //        arr[j + 1] = arr[j]; 
            //        j--;
            //    }
            //    arr[j + 1] = key;
            //    Console.WriteLine();
            //}


            // сортировка Шелла

            //int[] arr = new int[] { 5, 1, 4, 2, 8 };
            //int n = arr.Length, gap = n / 2;
            //while (gap > 0)
            //{
            //    for (int i = gap; i < n; i++)
            //    {
            //        foreach (double x in arr) Console.Write($"{x}  ");
            //        int key = arr[i], j = i - gap;
            //        while (j >= 0 && arr[j] > key)
            //        {
            //            arr
            //            [j + gap] = arr[j];
            //            j -= gap;
            //        }
            //        arr[j + gap] = key;
            //        Console.WriteLine();
            //    }
            //    gap /= 2;
            //}

            //int[,] matrix = new int[,] {
            //{ 1, 2, 3, 4 },
            //{ 5, -5, 5, -5 },
            //{ 6, 7, 8, 9 },
            //{ -6, -5, -8, 0 }};
            //int n = matrix.GetLength(0), m = matrix.GetLength(1);
            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    count = 0;
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (matrix[i, j] < 0) count++;
            //    }
            //    Console.WriteLine(count);
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");

            //    }
            //    Console.WriteLine();
            //}



            // пузырек
            //int[] A = new int[] { 5, 8, 9, -2, 0, 3 };
            //for (int i = 0; i < A.Length; i++)
            //{
            //    for (int j = i + 1; j < A.Length; j++)
            //    {
            //        if (A[i] < A[j])
            //        {
            //            int t = A[i];
            //            A[i] = A[j];
            //            A[j] = t;
            //        }

            //    }
            //}

            //гномик
            //int[] A = new int[] { 5, 8, 9, -2, 0, 3 };
            //for (int i = 1; i < A.Length; )
            //{
            //    if (i <= 0 || A[i - 1] < A[i])
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        int t = A[i];
            //        A[i] = A[i - 1];
            //        A[i - 1] = t;
            //        i--;
            //    }
            //}


            //крутой гномик
            //int[] A = new int[] { 5, 8, 9, -2, 0, 3 };
            //for (int i = 1, j = 2; i < A.Length; )
            //{
            //    if (i <= 0 || A[i - 1] < A[i])
            //    {
            //        i = j;
            //        j++;
            //    }
            //    else
            //    {
            //        int t = A[i];
            //        A[i] = A[i - 1];
            //        A[i - 1] = t;
            //        i--;
            //    }
            //}

            //вставочка
            //int[] A = new int[] { 5, 8, 9, -2, 0, 3 };
            //for (int i = 1; i < A.Length; i++)
            //{
            //    int key = A[i], j = i - 1;
            //    while(j >= 0 && A[j] > key)
            //    {
            //        A[j + 1] = A[j];
            //        j--;
            //    }
            //    A[j + 1] = key;
            //}

            // шеллик
            //int[] A = new int[] { 5, 8, 9, -2, 0, 3 };
            //int n = A.Length, gap = n / 2;
            //while (gap > 0)
            //{
            //    for (int i = gap; i < n; i++)
            //    {
            //        int key = A[i], j = i - gap;
            //        while ( j >= 0 && A[j] > key)
            //        {
            //            A[j + gap] = A[j];
            //            j -= gap;
            //        }
            //        A[j + gap] = key;
            //    }
            //    gap /= 2;
            //}
            //foreach (int x in A) Console.WriteLine(x);




            int[] a = new int[] { 1, 7, -3, 0, -2, 3 };
            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i], j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
            foreach(int x in a) Console.WriteLine(x);
        }

    }
}
