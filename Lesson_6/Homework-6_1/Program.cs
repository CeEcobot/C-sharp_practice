// Пользователь вводит с клавиатуры М чисел.
// Посчитайте сколько чисел больше 0 ввел пользователь.
// 0,7,8,-2,-2 -> 2
// -1,-7,567,89,223 -> 3

int PositiveNum(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}
Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = PositiveNum(a);
Console.WriteLine($"Количество числе больше 0: {result}");

