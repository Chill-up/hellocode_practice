// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); //до 100 потому что 

Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit == secondDigit) Console.WriteLine("Числа равны");
else
{
    int max = firstDigit > secondDigit ? firstDigit : secondDigit; //тернарный оператор. Если first больше second, то выводим первое, если нет, второе.
    Console.WriteLine($"наибольшая цифра числа {number} -> {max}");
}
