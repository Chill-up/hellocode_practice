// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());

void FirstNFibo(int num)
{
    int firstFibo = 0;
    int secondFibo = 1;
    Console.Write($"{firstFibo} {secondFibo} ");
    for (int i = 2; i < num; i++)
    {
        int nextFibo = secondFibo + firstFibo;
        Console.Write($"{nextFibo} ");
        firstFibo = secondFibo;
        secondFibo = nextFibo;
    }
}

FirstNFibo(number);