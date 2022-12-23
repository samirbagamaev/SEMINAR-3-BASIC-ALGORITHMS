// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты точки X ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y ");
int Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки X1 ");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки Y1 ");
int Y1 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2));

Console.WriteLine($"Расстояние между точками =  {result}");