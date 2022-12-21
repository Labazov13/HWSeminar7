/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetAndPrintArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
            System.Console.Write(result[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return result;
}

/*int[] massiv=array.GetLength(1);
if(i==0,j==0    i==0,j==1   i==0,j==2   i==0,j==3)
   i==1,j==0    i==1,j==1   i==1,j==2   i==1,j==3
   i==2,j==0    i==2,j==1   i==2,j==2   i==2,j==3
   i==3,j==0    i==3,j==1   i==3,j==2   i==3,j==3
*/
double[] SumArray(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
            {
                newArray[j] += array[i, j];
            }
            if (j == 1)
            {
                newArray[j] += array[i, j];
            }
            if (j == 2)
            {
                newArray[j] += array[i, j];
            }
            if (j == 3)
            {
                newArray[j] += array[i, j];
            }
        }

    }
    return newArray;
}
double[] MediumArifm(int[,] array, double[] arr)
{
    double[] Array = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        Array[i] = arr[i] / array.GetLength(1);
        System.Console.Write(Array[i] + " ");
    }
    return Array;
}

int[,] array = GetAndPrintArray(4, 4, 5, 11);
double[] arr = SumArray(array);
System.Console.WriteLine();
System.Console.Write(String.Join(" ", arr));
System.Console.WriteLine();
MediumArifm(array, arr);


