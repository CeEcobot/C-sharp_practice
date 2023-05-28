// 1. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

void Print(int[,] arr)
{
    int row = arr.GetLength(0); // первый параметр row => 0 (свойства массива по ширине)
    int column = arr.GetLength(1); // второй параметр column => 1 (свойства массива по высоте)

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        
            Console.Write($" {arr[i, j]} ");
    
        Console.WriteLine();
    }
}

//Блок формирования двумерного массива 
// (принмает размер и от и до каких числе работаем):
int[,] FillMass(int row, int column, int from, int to) // [,] - означает двумерный массив
{
    int[,] arr = new int[row, column]; // row = 3, column = 4

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        
            arr[i, j] = i +j; // i = 0,1,2,3; j = 0,1,2,3,4
        
    }

    return arr;
}

// ~ РЕШЕНИЕ ~ :


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
//int[,] mass2 =  CopyMass(mass);
//Console.WriteLine();
//Print(mass2);