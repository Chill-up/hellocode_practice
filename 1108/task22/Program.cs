// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите целое число для получения таблицы квадратов всех чисел от 1 до этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("__________________________");
Console.WriteLine("");
Console.WriteLine("Число     | Квадрат числа");
Console.WriteLine("__________________________");
int count = 1;
int square = count;
while (count <= number)
{
    square = count * count;
    Console.WriteLine($"   {count}      |   {square} ");
    count++;
}
Console.WriteLine("__________________________");
