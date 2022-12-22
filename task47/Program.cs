// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите нижнюю границу генерации чесил в массиве ");
double minBorder = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю границу генерации чесил в массиве ");
double maxBorder = double.Parse(Console.ReadLine()!);

double[,] doubleArray = CreateDouble2DArray(m, n, minBorder, maxBorder);

Print2DArray(doubleArray);

double[,] CreateDouble2DArray(int m, int n, double minBorder, double maxBorder)
{
    double[,] matrix = new double[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (maxBorder - minBorder) + minBorder, 1);
        }
    }
    return matrix;
}

 
void Print2DArray(double[,] matrix)
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