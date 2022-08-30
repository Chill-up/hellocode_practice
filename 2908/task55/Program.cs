// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" ]");
    }
}

int[,] CreateMatrixRandomInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] RotateMatrix(int[,] matrix) // реализовано через создание нового массива. 
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[,] res = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            res[i, j] = matrix[j, i];
        }
    }
    return res;
}

int[,] matrix = CreateMatrixRandomInt(4, 4, 0, 10); 
//пока работает только для квадратных массивов... Вне метода нужно реализовать проверку

PrintMatrixInt(matrix);

int[,] rotate90deg = RotateMatrix(matrix);
Console.WriteLine();
PrintMatrixInt(rotate90deg);