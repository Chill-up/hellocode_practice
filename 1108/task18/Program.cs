// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
//   y    
// 2 | 1
// ________ x
// 3 | 4

Console.WriteLine("Введите номер четверти от 1 до 4:");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

string CoordinateRange(int qn)
{
    if (qn == 1) return "Возможнный диапазон координат в этой четверти: x > 0 и y > 0";
    if (qn == 2) return "Возможнный диапазон координат в этой четверти: x < 0 и y > 0";
    if (qn == 3) return "Возможнный диапазон координат в этой четверти: x < 0 и y < 0";
    if (qn == 4) return "Возможнный диапазон координат в этой четверти: x > 0 и y < 0";
    return "Введено не верное значение";
}

string result = CoordinateRange(quarterNumber);
Console.WriteLine(result);
