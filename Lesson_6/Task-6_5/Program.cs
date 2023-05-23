// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

// Блок вывода одномерного массива:
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Блок формирования двумерного массива 
// (принмает размер и от и до каких числе работаем):
int[,] FillMass(int rows, int columns, int from, int to) // [,] - означает двумерный массив
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }

    return arr;
}

// ~ РЕШЕНИЕ ~ :
int[,] CopyMass(int[,]arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,]NewArr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArr[i,j] = arr[i,j];
        }
    }
    return NewArr;
}

// Блок ввода данных размерности массива:
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!); // размерность
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!); // с какого числа начинаем
Console.WriteLine("Диапозон от: ");
int from = int.Parse(Console.ReadLine()!); // на каком числе заканчиваем -1, тк верхняя граница не ваходит
Console.WriteLine("Диапозон до: ");
int to = int.Parse(Console.ReadLine()!);

int[,] mass = FillMass(rows, columns, from, to);
Print(mass);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :
int[,] mass2 =  CopyMass(mass);
Console.WriteLine();
Print(mass2);