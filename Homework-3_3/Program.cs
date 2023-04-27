// Напишите программу, которая принимает на вход число (N) и 
// выдает таблицу кубов числе от 1 до N
// 3 -> 1,8,27
// 5 -> 1,8,27,64,125

int num = int.Parse(Console.ReadLine()!);
void Div(int n)
{
    int i = 1;
while(n>=i)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}
}
Div(num);

