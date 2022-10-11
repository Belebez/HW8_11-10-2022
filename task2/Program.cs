// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int rows = new Random().Next(3, 11);
int columns = new Random().Next(3, 11);
Console.WriteLine($"Двумерный массив размером {rows}x{columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
MinSumElemInRow(array);


int[,] GetArray(int row, int column)  // функция заполнения массива
{
    int[,] result = new int[row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-100, 101);
        }
    }
    return result;
}

void MinSumElemInRow(int[,] array)  // считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов
{
    int sum0 = 0;
    int MinSum = 10000000;
    int row = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum0 += array[i, j];
        }
            if (MinSum >= sum0)
            {
                MinSum = sum0;
                row = i;
            }
            sum0 = 0; //  обнуляем сумму для сверки в след. цикле.
    }
    Console.WriteLine($"С наименьшей суммой элементов {MinSum} является строка {row}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}