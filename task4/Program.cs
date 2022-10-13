// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int rows = new Random().Next(2, 3);
int columns = new Random().Next(2, 3);
int depth = new Random().Next(2, 3);
Console.WriteLine($" Массив размером {rows}x{columns}x{depth}");
Console.WriteLine();

int[,,] array1 = GetArray(rows, columns, depth);
Console.WriteLine("Трёхмерный массив с индексами элемента: ");
PrintArray(array1);


int[,,] GetArray(int row, int column, int depth)  // функция заполнения массива
{
    int[,,] result = new int[row, columns, depth];
    int[] ArrayNonrepeatNumbers = new int[row * column * depth];
    int number;
    for (int i = 0; i < ArrayNonrepeatNumbers.GetLength(0); i++)
    {
        ArrayNonrepeatNumbers[i] = new Random().Next(10, 100);
        number = ArrayNonrepeatNumbers[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (ArrayNonrepeatNumbers[i] == ArrayNonrepeatNumbers[j])
                {
                    ArrayNonrepeatNumbers[i] = new Random().Next(10, 100);
                    j = 0;
                    number = ArrayNonrepeatNumbers[i];
                }
                number = ArrayNonrepeatNumbers[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = ArrayNonrepeatNumbers[count];
                count++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}{(j, k, i)} ");
            }
            Console.WriteLine();
        }
    }
}