//  Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

// Вариант решения без функции:
// int num = new Random().Next(100, 1000);
// Console.WriteLine (num);
// Console.WriteLine (num % 10);

// Вариант решения с функцией:
int TakeNum(int num)
{
   Console.WriteLine (num);
   return num % 10; 
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine (result);
