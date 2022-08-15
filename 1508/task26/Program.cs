// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNumbers(int num)
{
    int counter = 1;
    while (num >= 10)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}
int res = CountNumbers(number);

Console.WriteLine($"Кол-во цифр в числе {number} = {res}");

// вариант через for (извращенский)
// int counter = 1;
// for (; number >= 10; number = number / 10)
// {
//     counter++;
// }
// Console.WriteLine(counter);