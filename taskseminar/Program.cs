// Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

int rows = new Random().Next(3, 11);
int columns = new Random().Next(4, 11);
Console.WriteLine($"Двумерный массив размером {rows}x{columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
SortedArray(array);
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

void SortedArray(int[,] array)  // функция сортировки нечетных столбцов массива по возрастанию.
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1);)
        {
            for (int k = 0; k < array.GetLength(0) - 1; k++)
            {
                if (array[k, j] > array[k + 1, j])
                {
                    int t = array[k + 1, j];
                    array[k + 1, j] = array[k, j];
                    array[k, j] = t;
                }
            }
            j += 2;
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