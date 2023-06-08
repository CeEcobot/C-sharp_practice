// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

// ~ РЕШЕНИЕ ~ :
int IntegersSum(int M, int N)
{
    if(M == N) return N; // базовое условие работы
    else return M + IntegersSum(M + 1, N);
}


Console.WriteLine("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :

IntegersSum(M, N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {IntegersSum(M , N)}");