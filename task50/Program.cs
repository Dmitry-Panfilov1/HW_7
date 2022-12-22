// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите строку искомого элемента (отсчет номеров строк начинается с 0)");
int rowElementPosition = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите столбец искомого элемента (отсчет номеров столбцов начинается с 0)");
int coloumnElementPosition = int.Parse(Console.ReadLine()!);

int[,] array2D = Create2DArray(m, n);

Print2DArray(array2D);

SearchElement(array2D, rowElementPosition, coloumnElementPosition);

void SearchElement(int[,] matrix, int rowPosition, int coloumnPosition)
{
    if(rowPosition < matrix.GetLength(0) 
       && coloumnPosition < matrix.GetLength(1)
       && rowPosition >= 0
       && coloumnPosition >= 0)
    {
        Console.WriteLine(matrix[rowPosition, coloumnPosition]);
    }
    else
    {
        Console.WriteLine("такого числа нет в массиве");        
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] matrix = new int[m, n];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
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