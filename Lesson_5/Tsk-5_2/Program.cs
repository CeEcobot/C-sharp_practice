// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот [-4,-8,8,2] ->
//[4,8,-8,-2]
// *Нужно элементы просто умножить на -1


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
    {
        arr[i] = new Random().Next(from, to); // здесь мы собираемся
    }
    return arr; 
}

void MassConvert (int[] array)
{
    for (int i=0; i < array.Length; i++)
    array[i] = -array[i];
}

Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!); // размерность
Console.WriteLine("Введите мин значение для диапозона случайных чисел: ");
int start = int.Parse(Console.ReadLine()!); // с какого числа начинаем
Console.WriteLine("Введите макс значение для диапозона случайных чисел: ");
int stop = int.Parse(Console.ReadLine()!); // на каком числе заканчиваем -1, тк верхняя граница не ваходит

int[] mass = MassNums(num, start, stop);
Print(mass);

MassConvert(mass);
Print(mass);