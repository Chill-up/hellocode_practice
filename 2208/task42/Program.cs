// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число:");
int num = Convert.ToInt32(Console.ReadLine());

int DecToBin(int number)
{
    int result = 0;
    int mult = 1;
    while (number > 0)
    {
        result += number % 2 * mult;
        number /= 2;
        mult *= 10;
    }
    return result;
}

int result = DecToBin(num);
Console.WriteLine(result);