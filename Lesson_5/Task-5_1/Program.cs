// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных чисел равна -20.

void Print(int[] arr) // Блок вывода одномерного массива
{
    int size = arr.Length;

    for (int i = 0; i < size; i++) // Цикл "for"
        Console.WriteLine($"{arr[i]} "); // здесь мы показываемся
    Console.WriteLine(); // Больше отбивающая строка, если печатаем несколько массивов, чтобы между ними был отступ
}

int[] MassNums(int size, int from, int to) //Блок формирования одномерного массива (принмает размер и от и до каких числе работаем)
{
    int[] arr = new int[size]; // В теле собираем новый массив с зашедшей размерностью

    for (int i = 0; i < size; i++) // Цикл "for"
        arr[i] = new Random().Next(from, to); // здесь мы собираемся
    return arr;
}

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}

int num = int.Parse(Console.ReadLine()!); // размерность
int start = int.Parse(Console.ReadLine()!); // с какого числа начинаем
int stop = int.Parse(Console.ReadLine()!); // на каком числе заканчиваем -1, тк верхняя граница не ваходит

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);