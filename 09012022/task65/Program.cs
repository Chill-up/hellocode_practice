// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите целое положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

void NaturalNumberRowMN(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
        return;
    }
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumberRowMN(m - 1, n);
    }
    else 
    {
        NaturalNumberRowMN(m, n - 1); // важен порядок команд. Либо в прямом порядке, либо в обратном.
        Console.Write($"{n} ");
    }
}

NaturalNumberRowMN(numberM, numberN);