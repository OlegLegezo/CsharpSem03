// Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
//float
Console.Write("задайте координату Х первой точки");
double x1 = double.Parse(Console.ReadLine());
Console.Write("задайте координату У первой точки");
double y1 = double.Parse(Console.ReadLine());
Console.Write("задайте координату Х второй точки");
double x2 = double.Parse(Console.ReadLine());
Console.Write("задайте координату У второй точки");
double y2 = double.Parse(Console.ReadLine());

double x = x2 - x1;
double y = y2 - y1;

double answer = Math.Sqrt(x * x + y * y);

Console.WriteLine(answer);




