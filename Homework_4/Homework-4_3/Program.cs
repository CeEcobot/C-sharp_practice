// напишите программу, которая задает массив из 8 элементов случайными числами
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции.

void Print(int[] arr) // Блок вывода одномерного массива
{
    int size = arr.Length;

    for (int i = 0; i < size; i++) // Цикл "for"
    {
        Console.WriteLine($"{arr[i]} "); // здесь мы показываемся
        Console.WriteLine(); // Больше отбивающая строка, если печатаем несколько массивов, чтобы между ними был отступ
    }
}

int Mass(int size, int from, int to) //Блок формирования одномерного массива (принмает размер и от и до каких числе работаем)
{
    int[] arr = new int[size]; // В теле собираем новый массив с зашедшей размерностью

    for (int i = 0; i < size; i++) // Цикл "for"
        arr[i] = new Random().Next(from, to); // здесь мы собираемся
    return arr;
}

int num = int.Parse(Console.ReadLine()!); // размерность
int start = int.Parse(Console.ReadLine()!); // с какого числа начинаем
int stop = int.Parse(Console.ReadLine()!); // на каком числе заканчиваем -1, тк верхняя граница не ваходит

int[] mass = Mass(num, start, stop);
Print(mass);