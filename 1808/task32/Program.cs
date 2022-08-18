// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] PosToNeg(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] arr = CreateAndFillArrayRandomInt(5, -9, 9);
PrintArray(arr);
int[] result = PosToNeg(arr);
Console.WriteLine();
PrintArray(result);