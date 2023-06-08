// 4. Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243
// A = 2; B = 3 -> 8

// ~ РЕШЕНИЕ ~ :
int Power(int A, int B)
{
    if(B == 0) return 1; // Если любое число возвести в 0 степень, будет 1
    return A * Power(A, B - 1); 
    // N % 10 предыдущая цифра + каждый вызов функции уменьшает разряд
}

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите в какую степень возвести: ");
int B = int.Parse(Console.ReadLine()!);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :

Console.WriteLine (Power(A, B));