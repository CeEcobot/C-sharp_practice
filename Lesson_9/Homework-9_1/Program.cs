// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

// ~ РЕШЕНИЕ ~ :
void IntegersNums(int M, int N)
{
    if(M > N) return; // базовое условие работы
    if(M % 2 == 0)
    Console.WriteLine($"Четные натуральные числа: {M}");
    IntegersNums(M+1, N); 
}

Console.WriteLine("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :

IntegersNums(M, N);