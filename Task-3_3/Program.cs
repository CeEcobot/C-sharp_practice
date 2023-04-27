// Напишите программу, которая принимает на вход 
// координаты двух точек и нраходит расстояние между ними в 2D
// A(3,6); B(2,1) -> 5,09
// B(7,-5); B(1,-1) -> 7,21

double Dis(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
Console.WriteLine(Dis(3, 6, 2, 1));


