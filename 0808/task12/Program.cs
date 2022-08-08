// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
void CheckNum(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"Число {num1} кратно {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток от деления = " + num1 % num2); //два раза вычисляется остаток, можно вывести в отдельную переменную
    }
}

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine()); //принимаем пользовательский ввод и конвертируем в число
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

CheckNum(firstNumber, secondNumber);
