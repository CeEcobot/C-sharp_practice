// Напишите программу, которая на вход принимает число N
// и выдает произведение чисел от 1 до N
// 4->24, 5->120

int MultNum(int num)
{
    int multiply = 1;
    for (int i = 1; i <= num; i++)
        multiply *= i;

    return multiply;
}

int N = int.Parse(Console.ReadLine()!);
int result = MultNum(N);
Console.WriteLine(result);
