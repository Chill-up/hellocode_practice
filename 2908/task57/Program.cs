// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1] + "]");
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

int[] ConvertMatrix2Array(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count] = matrix[i, j];
            count++;
        }
    }
    Array.Sort(result);
    return result;
}

void CountSimilarElements(int[] array)
{
    int count = 1;
    int currentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"Число {currentNumber} повторяется {count} раз");
            currentNumber = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
        {
            Console.WriteLine($"Число {currentNumber} повторяется {count} раз");
        }
    }
}

int[,] matr = CreateMatrixRandomInt(3, 3, 0, 10);

PrintMatrixInt(matr);
Console.WriteLine();
int[] res = ConvertMatrix2Array(matr);
PrintArray(res);
Console.WriteLine();
CountSimilarElements(res);