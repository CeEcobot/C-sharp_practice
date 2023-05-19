// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе



int SumNum (int num)
{
int num_sum = 0;
while (num > 0)
{
    num_sum += num % 10;
    num /= 10;
}
return num_sum;
}

Console.WriteLine("Введите целое положительное число: ");
int num_A = int.Parse (Console.ReadLine()!);
int result = SumNum (num_A);
Console.WriteLine ($"Сумма цифр в числе: {result}");
