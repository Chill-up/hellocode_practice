// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.WriteLine("Введите число, равное первой стороне:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, равное второй стороне:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, равное третьй стороне:");
int numC = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int a, int b, int c)
{
    return a + b > c && b + c > a && c + a > b;
}

bool res = IsTriangle(numA, numB, numC);
if (res) Console.WriteLine("Введенные числа являются сторонами треугольника");
else Console.WriteLine("Введенные числа не являются сторонами треугольника");