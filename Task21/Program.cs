// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √ (x b - x a) 2 + (y b - y a) 2 + (z b - z a) 2

Console.Clear();

Console.WriteLine("Введите координаты первой точки");
Console.Write("Введите координату x: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки");
Console.Write("Введите координату x: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z: ");
int z2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между точками равно {result:f2}");