// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateAndFillArray01(int numelements, int min, int max)
{
    int[] array = new int[numelements]; // создаем новый массив на numelements элементов. Он по-умолчанию заполнен нулями.
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max); //случайное число от min до max (не включительно, если max 2, то попадут только 0 и 1 )
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]},");
        if (i < arr.Length - 1) Console.Write(arr[i] + ","); //arr.Length - 1 чтобы перед последним элементом была запятая.
        else Console.Write(arr[i] + "]");
    }
}

int[] result = CreateAndFillArray01(8, 0, 2); //вызываем метод заполнения массива на 8 элементов, заполняем случайными числами от 0 до 1 
PrintArray(result);