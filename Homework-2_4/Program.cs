// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным


void Weekend(int num)
{
    string text = "not quite a week";
    if(num==7 || num==6) text = "weekend";
    else if (num < 6 && num >0) text = "workday";

    Console.WriteLine($"{num} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()!));