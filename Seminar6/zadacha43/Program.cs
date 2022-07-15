// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double PointCoordinateX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double PointCoordinateY(double k2, double x, double b2)
{
    double y = k2 * x + b2;
    return y;
}

Console.WriteLine("Введите значения уравнения первой прямой y = k1 * x + b1");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значения уравнения второй прямой y = k2 * x + b2");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = PointCoordinateX(k1, b1, k2, b2);

if(k1 == k2) 
    Console.WriteLine("Прямые не пересекаются (прямые параллельны)");

else    
    Console.WriteLine($"Точка пересечения двух прямых : ({x} ; {PointCoordinateY(k2, x, b2)})");