Console.Clear();
Console.WriteLine("Введите число 1");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int N3 = Convert.ToInt32(Console.ReadLine());
int max = N1;
if (N2 > max)
    max = N2;
if (N3 > max)
    max = N3;
Console.WriteLine(max);