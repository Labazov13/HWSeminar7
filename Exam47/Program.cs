/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] GetArray(int m, int n)
{
    double[,] newArray = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().NextDouble() * 7;
        }
    }
    return newArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(array[i, j],2)} ");
        }
        System.Console.WriteLine();
    }
}

double[,] array = GetArray(4, 4);
PrintArray(array);
