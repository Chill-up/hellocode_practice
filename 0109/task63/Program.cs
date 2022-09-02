
//Вывести числа от 1 до N


Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumberRow(int num)
{
    if (num == 0) return;
    NaturalNumberRow(num - 1);
    Console.Write($"{num} ");
}

NaturalNumberRow(number);