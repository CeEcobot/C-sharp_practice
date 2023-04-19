// Напишите программу, которая выводит случайное трехзначное число и
// удаляет вторую цифру этого числа

int DeLNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 100 * 10;
    int num2 = num % 10;
    return num1 + num2;
}

int result = DeLNum (new Random().Next(99, 1000));
Console.WriteLine(result);

