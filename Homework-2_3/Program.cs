// Напишите программу, которая выводит третью цифру слева заданного числа,
// или сообщает, что третьей цифры нет.

void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("Вы ввели не трехзначное число");
        return;
    }
    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()!));
