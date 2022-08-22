// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число:");
int num = Convert.ToInt32(Console.ReadLine());

// int DecToBin(int number)
// {
//     int result = 0;
//     int mult = 1;
//     while (number > 0)
//     {
//         result += number % 2 * mult;
//         number /= 2;
//         mult *= 10;
//     }
//     return result;
// }

// int result = DecToBin(num);
// Console.WriteLine(result);

void DecToBinRecurs(int n) // n 13
{
    if (n == 0) return;
    DecToBinRecurs(n / 2); // n 6 и т.п.
    Console.Write(n % 2); // эта инструкция выполняется после того как отработали предыдущие. 
    //Стек раскручивается в обратном порядке: n = 1, 3, 6, 13 , от них уже берутся остатки от деления и выводятся в консоль.
    // если выводить Console.Write до рекурсии, то это будет хвостовая рекурсия и будет реверсивный ответ в данном случае.
}
DecToBinRecurs(num);