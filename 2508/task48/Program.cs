// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixMN(int row, int col)
{
    int[,] matrix = new int[row, col]; // чтобы получить длину массива row*col можно дописать .Length в конце.
    for (int i = 0; i < row; i++) // можно указать < matrix.GetLength(0) 
    {
        for (int j = 0; j < col; j++) // можно указать < matrix.GetLength(1) 
        {
            matrix[i, j] = i + j;
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

int[,] mtrx = CreateMatrixMN(3, 4);
PrintMatrix(mtrx);
