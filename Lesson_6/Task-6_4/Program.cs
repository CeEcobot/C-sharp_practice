// Не используя рекурсию, выведите первые N чисел Фибоначи. 
// первые два числа Фибоначи: 0, 1.
// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358

void Fib(int a)
{
int festNum = 0;
int secontNum = 1;
for (int i = 0; i < a; i++)
{
Console.Write(festNum + " ");
(festNum, secontNum) = (secontNum, festNum + secontNum);
}
}
int A = int.Parse(Console.ReadLine()!);
Fib(A);

