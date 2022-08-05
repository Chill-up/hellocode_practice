// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int num2square = number2 * number2;

if (num2square == number1)
{
    Console.WriteLine($"а = {number1}, b = {number2} -> да ");
}
else 
{
    Console.WriteLine($"а = {number1}, b = {number2} -> нет ");
}