// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SumNumbersRow(int[,] matrix, int rows)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[rows, i];
    }
    return sum;
}

int FindRowMinSum(int[,] matrix)
{
    int rowMinSum = 0;
    int minSum = SumNumbersRow(matrix, rowMinSum);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = SumNumbersRow(matrix, i);
        if (minSum > sum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    return rowMinSum;
}


int amountRows = Prompt("Введите желаемое количество строк в массиве");
int amountColumns = Prompt("Введите желаемое количество столбцов");
int[,] numbers = CreateMatrix(amountRows, amountColumns);
PrintMatrix(numbers);
System.Console.WriteLine("Минимальная сумма элементов находится" +
    $" в {FindRowMinSum(numbers) + 1} строке массива");



