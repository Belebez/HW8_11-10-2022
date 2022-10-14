// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);

SpiralArray(rows, columns);

void SpiralArray(int rows, int columns)
{
    if (rows == columns)
    {
        int[,] array = new int[rows, columns];
        int temp = 1;
        int i = 0;
        int j = 0;

        while (temp <= array.GetLength(0) * array.GetLength(1))
        {
            array[i, j] = temp;
            temp++;
            if ((i <= j + 1) && (i + j < array.GetLength(1) - 1))
                j++;
            else if ((i < j) && (i + j >= array.GetLength(0) - 1))
                i++;
            else if ((i >= j) && (i + j > array.GetLength(1) - 1))
                j--;
            else
                i--;
        }
        Console.WriteLine($"Массив размером {rows}x{columns}, заполнен по спирали: ");
        Console.WriteLine();

        for (int x = 0; x < array.GetLength(0); x++)
        {
        for (int y = 0; y < array.GetLength(1); y++)
            {
                if (array[x, y] / 10 <= 0)
                    Console.Write($" {array[x, y]} ");

                else Console.Write($"{array[x, y]} ");
            }
        Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Для заполнения по спирали, количество столбцов должно быть равно количеству строк.");
        Console.WriteLine();
    }
}