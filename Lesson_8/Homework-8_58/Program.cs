// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// https://ru.onlinemschool.com/math/assistance/matrix/multiply


// Блок вывода двумерного массива:
void Print(int[,] arr)
{
    int row = arr.GetLength(0); // первый параметр row => 0 (свойства массива по ширине)
    int column = arr.GetLength(1); // второй параметр column => 1 (свойства массива по высоте)

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        
            Console.Write($" {arr[i, j],3}"); // +3 эргономичное решение
    
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
        
            arr[i, j] = new Random().Next(from, to + 1); //+1 чтобы не обманывать пользователя
        
    }

    return arr;
}

// ~ РЕШЕНИЕ ~ :
int[,] MatrixProduct(int[,] arr_first, int[,] arr_second) // ищем суммы по строкам
{
    int row_1 = arr_first.GetLength(0);
    int column_1 = arr_first.GetLength(1);

    int row_2 = arr_second.GetLength(0);
    int column_2 = arr_second.GetLength(1);

    int[,] pr_matrix = new int[row_1, column_1]; // создаем одномер.массив размером = кол-ву строк в двумер.массиве

    // далее кол-во столбцов первой матрицы, должно совпадать 
    // с количеством строк второй

    if (column_1 != row_2) return pr_matrix; // проходимся по двумер.массиву

    else if (column_1 == row_2)
        pr_matrix = new int[row_1, column_2];

    for (int i = 0; i < row_1; i++)
    {
        for (int j = 0; j < column_2; j++)
        {
          for (int p = 0; p < column_1; p++) // работаем в диапозоне от 0 до кол-ва столбцов первой матрицы
          // берем строку первой матрицы и столбец второй,
          // перемножаем элементы, собираем сумму произведений.
          pr_matrix[i, j] += arr_first[i, p] * arr_second[p, j];
        }
    }
    return pr_matrix;
}

// Блок ввода данных размерности массива:
Console.WriteLine("Введите количество строк первого массива: ");
int row_1 = int.Parse(Console.ReadLine()!); // размерность
Console.WriteLine("Введите количество столбцов первого массива: ");
int column_1 = int.Parse(Console.ReadLine()!); // с какого числа начинаем

Console.WriteLine("Введите количество строк второго массива: ");
int row_2 = int.Parse(Console.ReadLine()!); // размерность
Console.WriteLine("Введите количество столбцов второго массива: ");
int column_2 = int.Parse(Console.ReadLine()!); // с какого числа начинаем

int[,] arr_1 = FillMass(row_1, column_1, 1, 10);
Print(arr_1);
int[,] arr_2 = FillMass(row_2, column_2, 1, 10);
Print(arr_2);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :

int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);