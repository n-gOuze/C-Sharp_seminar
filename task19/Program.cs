﻿Console.WriteLine("Введите координату x первой точки");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int yb = Convert.ToInt32(Console.ReadLine());
double c = Math.Pow(xb - xa, 2);
double d = Math.Pow(yb - ya, 2);
double sum = c + d;
double res = Math.Sqrt(sum);
Console.WriteLine(res);