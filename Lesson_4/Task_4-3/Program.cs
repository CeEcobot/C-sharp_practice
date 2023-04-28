// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void massive (int mas)
{
    int[] numbers = new int [mas]; // Размер массива mas = 8 чисел
    for (int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(2); // Random не включает верхнюю границу
        Console.WriteLine(numbers[i]);
    }
}
massive(8);