//Поиск точки пересечения 2-х прямых.
Console.Clear();
Console.WriteLine("Введите координату точки b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
double x, y = 0;
x = (b2 - b1) / (k1 - k2);
y = (k1 * x) + b1;
Console.WriteLine($"Координаты точки пересечения 2-х прямых: ({x} ; {y})");