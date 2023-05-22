// 2. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпсоледний
// и тд. Результат запишите в новом массиве.


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
int[] MultiMas(int[] arr)
{
    int size = arr.Length;
    int[] newMass = new int[size / 2 + size % 2];

    for (int i = 0; i < size / 2; i++)
    {
        newMass[i] = arr[i] * arr[size - 1 - i];
    }
    if (size % 2 == 1)
    {
        newMass[newMass.Length-1] = arr[arr.Length/2];
    }
    return newMass;
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
int[] newNewMass =  MultiMas(mass);
Print(newNewMass);
