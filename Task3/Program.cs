// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

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
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintMatrix2(int[,] matrix, int cursorPosition)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.SetCursorPosition(cursorPosition * 2, i + 2);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixMult.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                matrixMult[i, k] += matrix1[i, j] * matrix2[j, k];
            }
        }
    }
    return matrixMult;
}

Console.Clear();
int amountRows = Prompt("Введите желаемое количество строк в массиве");
int amountColumns = Prompt("Введите желаемое количество столбцов");
int[,] numbers = CreateMatrix(amountRows, amountColumns);
int[,] array = CreateMatrix(amountColumns, amountRows);
int[,] multNumbersArray = MultiplicationMatrix(numbers, array);
PrintMatrix(numbers);
PrintMatrix2(array, amountColumns + 2);
PrintMatrix2(multNumbersArray, amountColumns + amountRows + 4);

