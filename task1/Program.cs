// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int rows = new Random().Next(3, 11);
int columns = new Random().Next(3, 11);
Console.WriteLine($"Двумерный массив размером {rows}x{columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
SortedArrayRow(array);
Console.WriteLine();
Console.WriteLine("New sorted array: ");
PrintArray(array);


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

void SortedArrayRow(int[,] array)  // функция сортировки строк массива по убыванию
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[j, k] < array[j, k + 1])
                {
                    int t = array[j, k + 1];
                    array[j, k + 1] = array[j, k];
                    array[j, k] = t;
                }
            }
        }
        
    }
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