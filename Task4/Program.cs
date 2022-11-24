// Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiral(int[,] matrix)
{
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        int j = i;
        for (j = i; j < matrix.GetLength(1) - i; j++)
        {
            matrix[i, j] = count;
            count++;
        }
        int k = i + 1;
        for (k = i + 1; k < matrix.GetLength(0) - i; k++)
        {
            matrix[k, j - 1] = count;
            count++;
        }
        for (j -= 2; j >= i; j--)
        {
            matrix[k - 1, j] = count;
            count++;
        }
        for (k -= 2; k > i; k--)
        {
            matrix[k, i] = count;
            count++;
        }
    }
    if (matrix.GetLength(1) % 2 != 0) matrix[matrix.GetLength(1) / 2, matrix.GetLength(0) / 2] = count;
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

int[,] numbers = new int[4, 4];
FillSpiral(numbers);
PrintMatrix(numbers);