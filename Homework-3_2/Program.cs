// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между
// ними в 3D пространстве
// A(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11.53

double Dis(double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1,2)),2);
}

double x_1 = double.Parse(Console.ReadLine()!);
double y_1 = double.Parse(Console.ReadLine()!);
double z_1 = double.Parse(Console.ReadLine()!);
double x_2 = double.Parse(Console.ReadLine()!);
double y_2 = double.Parse(Console.ReadLine()!);
double z_2 = double.Parse(Console.ReadLine()!);

Console.WriteLine(Dis(x_1, y_1, z_1, x_2, y_2, z_2));

