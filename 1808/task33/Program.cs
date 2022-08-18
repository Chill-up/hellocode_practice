// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    } return false;
}

int[] arr = CreateAndFillArrayRandomInt(10, -9, 9);
PrintArray(arr);
//int num = Convert.ToInt32(Console.ReadLine()); можно сделать пользовательский ввод числа для поиска.
bool result = FindNum(arr, 9);
Console.WriteLine("Ищем в массиве число 9");
Console.WriteLine(result);