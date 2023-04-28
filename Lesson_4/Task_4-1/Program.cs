// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.
// 456->3, 78->2, 89126->5

int Length(int num)
{
    int a = 0;
    for(int i = 1; num > 0; i++)
    {
        num = num/10;
        a++;
    }
    return a;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = Length(num);
Console.WriteLine(result);
