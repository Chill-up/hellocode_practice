// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

int[,] IndexToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
    return matrix;
}

int[,] matrx = CreateMatrixRandomInt(3, 4, 0, 10);
PrintMatrix(matrx);
Console.WriteLine();
matrx = IndexToSquare(matrx);
PrintMatrix(matrx);
