
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