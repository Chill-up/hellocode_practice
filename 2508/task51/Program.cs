// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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

int SumElements(int[,] matrix)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) summ += matrix[i, j];
        }
    }
    return summ;
}

int SumElementsOneCicle(int[,] matrix)
{
    int summ = 0;
    int size = matrix.GetLength(0);
    // Т.к. индексы равны друг другу, нет смысла проходить 2 цикла for, поэтому оставляем один.
    // В таком случае если матрица не квадратная, то чтобы счетчик не выходил за границы массива, создаем переменную
    // записываем туда наименьшее значение из 2 индексов.
    if (matrix.GetLength(0) > matrix.GetLength(1)) size = matrix.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        int j = i;
        summ += matrix[i, j];
    }
    return summ;
}

int[,] matr = CreateMatrixRandomInt(5, 3, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
//int res = SumElements(matr);
int res = SumElementsOneCicle(matr);
Console.WriteLine(res);