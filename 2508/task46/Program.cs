// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] CreateMatrixRandomInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col]; // чтобы получить длину массива row*col можно дописать .Length в конце.
    Random rnd = new Random();
    for (int i = 0; i < row; i++) // можно указать < matrix.GetLength(0) 
    {
        for (int j = 0; j < col; j++) // можно указать < matrix.GetLength(1) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] mtrx = CreateMatrixRandomInt(3, 4, -99, 99);
PrintMatrix(mtrx);