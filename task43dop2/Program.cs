﻿Console.Clear();
Console.WriteLine("Введите координату точки x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки x3:");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки y3:");
int y3 = Convert.ToInt32(Console.ReadLine());
double AB, AC, BC, P, result = 0;
AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
P = (AC + AB + BC) / 2;
result = Math.Round(Math.Sqrt(P * (P - AC) * (P - AB) * (P - BC)), 2);
Console.WriteLine(result);