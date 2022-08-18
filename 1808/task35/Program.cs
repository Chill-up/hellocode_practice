// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1] + "]");
}

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

int FindInRange(int[] array, int min, int max)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min <= array[i] && array[i] <= max) counter++;
    }
    return counter;
}
int[] array = CreateAndFillArrayRandomInt(123, 0, 150);
PrintArray(array);
int result = FindInRange(array, 10, 99);
Console.WriteLine();
Console.WriteLine($"Количество чисел в диапазоне от 10 до 99 = {result}");