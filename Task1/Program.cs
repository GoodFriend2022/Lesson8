// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void ArrangeRow(int[,] matrix, int rows)
{
    int length = matrix.GetLength(1);
    int temp = 1;
    while (temp > 0 || length > 1)
    {
        temp = 0;
        for (int i = 1; i < length; i++)
        {
            if (matrix[rows, i - 1] < matrix[rows, i])
            {
                (matrix[rows, i - 1], matrix[rows, i]) = (matrix[rows, i], matrix[rows, i - 1]);
                temp++;
            }
        }
        length--;
    }
}

void ArrangeByRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        ArrangeRow(matrix, i);
    }
}

int[,] numbers = CreateMatrix(10, 10);
PrintMatrix(numbers);
ArrangeByRows(numbers);
System.Console.WriteLine();
PrintMatrix(numbers);
