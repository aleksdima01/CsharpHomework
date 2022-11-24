Console.Clear();
Console.WriteLine("Введите число 1");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int N2 = Convert.ToInt32(Console.ReadLine());
int max=0;
if (N1>N2)
max=N1;
else 
max=N2;
Console.WriteLine(max);