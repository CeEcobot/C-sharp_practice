// Напишите цикл, который принимает на вход два числа (А и В) и возводит
// число А в натуральную степень В

Console.WriteLine("Введите число A: ");
int num_A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите число B: ");
int num_B = int.Parse(Console.ReadLine()!);

double DegreeNum(int a, int b)
{
    double n_pow = 1;
    int b_abs = Math.Abs(b);

    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            n_pow *= a;
        else
            n_pow /= a;
    }
    return n_pow;
}

Console.WriteLine("A в степени B -> ");
Console.WriteLine(DegreeNum(num_A, num_B));
