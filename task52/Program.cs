// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);

int[,] array2D = Create2DArray(m, n);

Print2DArray(array2D);

double[] averageColoumnArray = AverageColoumn(array2D);

PrintArray(averageColoumnArray);

double[] AverageColoumn(int[,] matrix)
{
    double[] averageColoumnNumsArray = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageColoumnNumsArray[j] += matrix[i, j]; 
        }

        averageColoumnNumsArray[j] = Math.Round(averageColoumnNumsArray[j] / matrix.GetLength(0),1);
    }
    return averageColoumnNumsArray;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}   

int[,] Create2DArray(int m, int n)
{
    int[,] matrix = new int[m, n];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}
 
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}