// Напишите программу, которая на вход принимает число (N)
// и выдает таблицу квадратов чисел от 1 до N (включительно)

int num = int.Parse(Console.ReadLine()!);
void Div(int n)
{
    int i = 1;
while(n>=i)
{
    Console.WriteLine(Math.Pow(i,2));
    i++;
}
}
Div(num);