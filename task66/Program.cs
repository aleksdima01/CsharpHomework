//Сумма эл-ов в промежутке через рекурсию
int Interval(int a, int b)
{
    if (a == b)
        return a;
    return Interval(a, b - 1) + b;
}
Console.WriteLine("Введите число 1");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 0)
{
    Console.WriteLine("Начальное число не может быть отрицательным!\nВведите правильное число:");
    N = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число 2");
int M = Convert.ToInt32(Console.ReadLine());
while (N > M)
{
    Console.WriteLine("Конечное число не может быть меньше начального!\nВведите правильное число:");
    M = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Сумма элементов в вашем промежутке:{Interval(N, M)}");
