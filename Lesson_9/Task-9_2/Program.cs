// 2. Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M=1;N=5 -> 1,2,3,4,5
// M=4;N=8 -> 4,5,6,7,8

// ~ РЕШЕНИЕ ~ :
void NumsFromTo(int M, int N)
{
    if(M > N) return; // если 0 то выход и завершение. Зашла f(5)
    NumsFromTo(M, N-1); // f(5), f(4), f(3), f(2), f(1) / f(0) НЕ выводим!!! см строку выше!
    Console.Write($"{N}, ");
}

Console.WriteLine("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);
// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :

NumsFromTo(Num1, Num2);
