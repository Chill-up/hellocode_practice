// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Вывести результат.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateAndFillArrayRandomInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    // чтобы в цикле не сгенерировались 100500 одинаковых чисел, выносим в отдельную переменную rnd этот объект, а потом вызываем его в цикле.
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1); // +1, чтобы дойти до последнего элемента, т.к. счетчик с нуля.
    }
    return array;
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

int sumNeg = 0;
int sumPos = 0;

int[] GetSumPosAndNegElems(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];

        }
    }
    return new int[] {sumNeg,sumPos};
}

int[] res = CreateAndFillArrayRandomInt(12, -9, 9);
PrintArray(res);
Console.WriteLine();
int[] result = GetSumPosAndNegElems(res);
Console.WriteLine($"Сумма отрицательных чисел = {result[0]}");
Console.WriteLine($"Сумма положительных чисел = {result[1]}");