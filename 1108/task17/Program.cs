// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
//   y    
// 2 | 1
// ________ x
// 3 | 4

Console.WriteLine("Введите координаты точки не равные нулю ");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

string FindQuarter(int x1, int y1)
{
    if (x1 > 0 && y1 > 0) //else не нужны в методе, т.к. есть return, который возвращает значение и прерывает выполнение метода.
    {
        return "Точка в третьей четверти ";
    }
    if (x1 < 0 && y1 > 0)
    {
        return "Точка во второй четверти ";
    }
    if (x1 < 0 && y1 < 0)
    {
        return "Точка в третьей четверти ";
    }
    if (x1 > 0 && y1 < 0)
    {
        return "Точка в четвертой четверти ";
    }
    return "Введены не верные данные  ";
}

string result = (FindQuarter(x, y));
Console.WriteLine(result);