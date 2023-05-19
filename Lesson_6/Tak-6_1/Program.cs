// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)



// Блок вывода одномерного массива:
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

//Блок формирования одномерного массива 
// (принмает размер и от и до каких числе работаем):
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

// ~ РЕШЕНИЕ ~ :
void RevMas(int[] arr)
{
int size = arr.Length;
for (int i = 0; i < size / 2; i ++)
(arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
}

// Блок ввода данных размерности массива:
Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!); // размерность
Console.WriteLine("Диапозон от: ");
int start = int.Parse(Console.ReadLine()!); // с какого числа начинаем
Console.WriteLine("Диапозон до: ");
int stop = int.Parse(Console.ReadLine()!); // на каком числе заканчиваем -1, тк верхняя граница не ваходит

int[] mass = MassNums(num, start, stop);
Print(mass);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :
RevMas(mass);
Print(mass);
