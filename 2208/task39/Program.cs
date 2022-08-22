// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateAndFillArrayRandomInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

void ReverseArray(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        // стандартная схема замены элементов через временную переменную.
        int temp = array[index1];
        //создаем переменную temp в цикле, т.к. она больше нигде не используется. Для строк возможно так лучше не делать
        array[index1] = array[index2];
        array[index2] = temp;
        index1++;
        index2--;
    }
}

void ReverseArrayFor(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++) //size / 2 иначе цикл перевернет массив 2 раза и получим массив, равный исходному
    {
        int temp = array[i];
        array[i] = array[size - 1 - i]; //-i добавили чтобы счетчик сдвигался от конца массива, иначе будем один и тот же элемент всегда брать
        array[size - 1 - i] = temp;
    }
}

int[] arr = CreateAndFillArrayRandomInt(8, 1, 10);
PrintArray(arr);
Console.WriteLine();
//ReverseArray(arr);
ReverseArrayFor(arr);
PrintArray(arr);