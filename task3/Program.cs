// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18[0,0] = ([0,0]*[0,0] + [0,1]*[1,0]) 20[0,1] = ([0,0]*[0,1] + [0,1]*[1,1])
// 15[1,0] = ([1,0]*[0,0] + [1,1]*[1,0]) 18[1,1] = ([1,0]*[0,1] + [1,1]*[1,1])



int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
Console.WriteLine($"Матрицы размером {rows}x{columns}");
Console.WriteLine();

int[,] array1 = GetArray(rows, columns);
Console.WriteLine("Первая матрица: ");
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows, columns);
Console.WriteLine("Вторая матрица: ");
PrintArray(array2);
Console.WriteLine();
MultiplicationMatrix(array1, array2);


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

void MultiplicationMatrix(int[,] array, int[,] array1)  // функция произведения двух матриц
{
    int[,] NewArray = new int[array.GetLength(1), array.GetLength(0)];

    if (array.GetLength(1) != array1.GetLength(0))
    {
        Console.WriteLine("Матрицы не соответствуют условию для переумножения, число столбцов матрицы 1 должно равняется числу строк матрицы 2");
    }
    else
    {
        for (int i = 0; i < NewArray.GetLength(0); i++)
        {
            for (int j = 0; j < NewArray.GetLength(1); j++)
            {
                for (int k = 0; k < NewArray.GetLength(0); k++)
                {
                    NewArray[i,j] += array[i,k] * array1[k,j];
                }
            }
        } 
        Console.WriteLine("Полученная матрица после перемножения исходных матриц: ");
        PrintArray(NewArray);
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