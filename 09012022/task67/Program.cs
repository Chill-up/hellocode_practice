// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitsInNumber(int num)
{
    // int sum = 0;
    // if (num / 10 <= 0) return sum += num % 10;
    // sum += SumDigitsInNumber(num / 10);
    // return sum += num % 10;

    int sum = num % 10;
    if (num > 0) sum += SumDigitsInNumber(num / 10);
    return sum;
}

int res = SumDigitsInNumber(number);
Console.WriteLine(res);