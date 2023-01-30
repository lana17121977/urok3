// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату c первой точки");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату c второй точки");
int c2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( D (x1, y1, c1, x2, y2, c2));
Double D (int x1, int y1, int c1, int x2, int y2, int c2)
{
    Double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((c2 - c1), 2));
    return D;
}
