// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultFirstAndLast(int[] array)
{
    int size = array.Length / 2; //середина массива
    if (array.Length % 2 != 0) size += 1; //для нечетного добавляем одно место
    int[] res = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        res[i] = array[i] * array[array.Length - 1 - i];
        //умножаем, умножаем на элемент -1 (первый с последним) и текущий счетчик уменьшаем, чтобы двигаться к центру и записываем в новый массив.
    }
    if (array.Length % 2 != 0) //для нечетных чисел нужно добавить последний элемент от середины массива.
    {
        res[res.Length - 1] = array[size - 1]; //добавляем на последнюю позицию нового массива средний элемент основого массива.
    }
    return res;
}

int[] arr = CreateAndFillArrayRandomInt(5, 0, 10);
PrintArray(arr);
Console.WriteLine();
int[] result = MultFirstAndLast(arr);
PrintArray(result);
