// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void SwapRows(int[,] matrix)
{
    int firstRow = 0; //какую строку будем заменять
    int lastRow = matrix.GetLength(0) - 1; //на какую строку будем менять
    int colNumber = matrix.GetLength(1); 
    for (int i = 0; i < colNumber; i++) // проходиться будем по номеру столбцов, меняем через temp.
    {
        int temp = matrix[lastRow, i];
        matrix[lastRow, i] = matrix[firstRow, i];
        matrix[firstRow, i] = temp;
    }
}

int[,] matrix = CreateMatrixRandomInt(4, 5, 0, 10);

PrintMatrixInt(matrix);

SwapRows(matrix);
Console.WriteLine();
PrintMatrixInt(matrix);