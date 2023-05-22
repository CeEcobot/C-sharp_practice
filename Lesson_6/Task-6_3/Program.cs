// 2. Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string ConvertBin(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

int N = int.Parse(Console.ReadLine()!);
string ResultEnd = ConvertBin(N);
Console.WriteLine(ResultEnd);