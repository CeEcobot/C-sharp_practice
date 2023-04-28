// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом


Console.WriteLine("Введите положительное пятизначное число: ");
string Palindrome(int n)

{
    int num = 10000;
    if (num > 100000 || num < 10000)
        return "Вы ввели не пятизначное число или оно не положительное";

    while (num > 1)
    {
        if (n / num % 10 != n % 10)
            return "Число не является палиндромом";
        n /= 10;
        num /= 100;
    }
    return "Число является палиндромом";
}

Console.WriteLine(Palindrome(int.Parse(Console.ReadLine()!)));