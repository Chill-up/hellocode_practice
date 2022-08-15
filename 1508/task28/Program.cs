// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultSum(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        //sum = sum * i;
        sum *= i;
    }
    return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int res = MultSum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {res}");