// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементом массива.
// https://learn.microsoft.com/en-us/dotnet/api/system.random.nextdouble?view=net-6.0
// https://ru.stackoverflow.com/questions/1254105/Как-сгенерировать-случайное-дробное-число-из-интервала


// Блок вывода одномерного массива:
void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++) // Цикл "for"
        Console.Write($"{arr[i]} "); // здесь мы показываемся
    Console.WriteLine(); // Больше отбивающая строка, если печатаем несколько массивов, 
                        // чтобы между ними был отступ
}

//Блок формирования одномерного массива 
// (принмает размер и от и до каких числе работаем):
double[] MassNums(int size, int from, int to) // Лучшая реализация массива (НЕ писать в код диапозон!!!)
{
    double[] arr = new double[size]; // В теле собираем новый массив с зашедшей размерностью
    Random n_new = new Random();

    for (int i = 1; i < size; i++) // Цикл "for"
        arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2); // здесь мы собираемся
    return arr;
}

// ~ РЕШЕНИЕ ~ :
void DiffMaxMin(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr [0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])
            n_max = arr[i];

        else if (n_min > arr[i])
            n_min = arr[i];
    }

    Console.WriteLine($"Max: {n_max}, min: {n_min}. ");
    Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
}

// Блок ввода данных размерности массива:
Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!); // размерность
Console.WriteLine("Диапозон от: ");
int start = int.Parse(Console.ReadLine()!); // с какого числа начинаем
Console.WriteLine("Диапозон до: ");
int stop = int.Parse(Console.ReadLine()!); // на каком числе заканчиваем -1, тк верхняя граница не ваходит

double[] mass = MassNums(num, start, stop);
Print(mass);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :
DiffMaxMin(mass);
