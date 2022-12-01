Console.Clear();
Console.WriteLine("Введите координату точки Ax");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки Ay");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки Az");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки Yx");
double Yx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки Yy");
double Yy = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки Yz");
double Yz = Convert.ToDouble(Console.ReadLine());

double result = 0;
result = Math.Sqrt(Math.Pow(Ax - Yx,2) + Math.Pow(Ay - Yy,2) + Math.Pow(Az - Yz,2));
Console.WriteLine($"Расстояние между точками:{result}");
