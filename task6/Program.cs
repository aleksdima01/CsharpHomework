Console.Clear();
Console.WriteLine("Введите число:");
int N1 = Convert.ToInt32(Console.ReadLine());
if (N1 % 2 != 0)
    Console.WriteLine("Не четное");
else
    Console.WriteLine("Четное");