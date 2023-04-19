// Напишите программу, которая на вход принимает трехзначное число
// и на выходе показывает вторую цифру этого числа (456->5, 782->8, 918->1)

// *Нужно уменьшить на одну цифру и в этой же строке забрать цифру -
// %(на 100) и / (на 10).


//void - тоже правильно использовать
string TakeSecondNum(int num)
{
    if ((num > 99 && num < 1000) || (num > -99 && num < -1000))
       return $"{num / 10 % 10}";
    return "Вы ввели не положительное и/или не трехзначное число";
}

Console.WriteLine("Введите положительное трехзначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// TakeSecondNum(num);
Console.WriteLine(TakeSecondNum(int.Parse(Console.ReadLine()!)));
