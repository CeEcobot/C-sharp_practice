// Задайте одномерный массив заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных позициях.


// Блок вывода одномерного массива:
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++) // Цикл "for"
        Console.Write($"{arr[i]} "); // здесь мы показываемся
    Console.WriteLine(); // Больше отбивающая строка, если печатаем несколько массивов, 
                        // чтобы между ними был отступ
}

//Блок формирования одномерного массива 
// (принмает размер и от и до каких числе работаем):
int[] MassNums(int size, int from, int to) // Лучшая реализация массива (НЕ писать в код диапозон!!!)
{
    int[] arr = new int[size]; // В теле собираем новый массив с зашедшей размерностью
    for (int i = 0; i < size; i++) // Цикл "for"
        arr[i] = new Random().Next(from, to); // здесь мы собираемся
    return arr;
}

// ~ РЕШЕНИЕ ~ :
int EvenSum(int[] arr)
{
    int count = 0; // Объявляем элемент который будем отсчитывать

    for (int i = 0; i < arr.Length; i += 2) // работаем от 0 до длины массива НО с шагом 2
        count += arr[i]; //складываем сами значения

    return count; // возвращаем количество
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
Console.WriteLine(EvenSum(mass));
