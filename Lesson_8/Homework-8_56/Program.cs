// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// Блок вывода двумерного массива:
void Print(int[,] arr)
{
    int row = arr.GetLength(0); // первый параметр row => 0 (свойства массива по ширине)
    int column = arr.GetLength(1); // второй параметр column => 1 (свойства массива по высоте)

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        
            Console.Write($" {arr[i, j],4}");
    
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Блок формирования двумерного массива 
// (принмает размер и от и до каких числе работаем):
int[,] FillMass(int row, int column, int from, int to) // [,] - означает двумерный массив
{
    int[,] arr = new int[row, column]; 

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        
            arr[i, j] = new Random().Next(from, to); 
        
    }

    return arr;
}

// ~ РЕШЕНИЕ ~ :
int[] SumNum(int[,] arr) // ищем суммы по строкам
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    int[] all_nums = new int[row]; // создаем одномер.массив размером = кол-ву строк в двумер.массиве

    for (int i = 0; i < row; i++) // проходимся по двумер.массиву
    {
        for (int j = 0; j < column; j++)
        {
            all_nums[i] += arr[i, j];
        }
        // т.к. индекс эл-а в одномер.массиве соответсвует номеру строки
        // в двумер.массиве, то заполняем этот эл-т значениями и прибавляем 
        // туда значения всех эл-ов внутри конкретной строки
    }
    return all_nums; // возвращаем сумму
}

void FindMin (int[]arr) // функция, которая обрабатывает этот массив сумм
{
    int min_num = 0; // принимаем индекс мин знач = 0
    for (int i = 1; i < arr.Length; i++) // тк индекс 0 мало интересует не имеет
    //смысла сравнивать нулевой элемент с переменной которая содержит значение
    // нулевого элемента
    if (arr[i] < arr[min_num]) min_num = i; //если текущий элемеент меньше
    // чем тот который стоит на minIndex -> minIndex присваиваем значение 
    // текущего индекса
    Console.WriteLine($"Sum of elements: {arr[min_num]}, line: {min_num + 1}");
    // row_num: вывод индекса, row_num+1: вывод порядкого номера
}

// Блок ввода данных размерности массива:
Console.WriteLine("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!); // размерность
Console.WriteLine("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!); // с какого числа начинаем
Console.WriteLine("Диапозон от: ");
int start = int.Parse(Console.ReadLine()!); // на каком числе заканчиваем -1, тк верхняя граница не ваходит
Console.WriteLine("Диапозон до: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = FillMass(row_num, column_num, start, stop);
Print(mass);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :

int[] mass_sum = SumNum(mass);
FindMin(mass_sum);
