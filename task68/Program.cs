//Ф-ия Аккермана
int Akkerman(int a, int b)
{
    if (a == 0)
        return b + 1;
    else if (b == 0)
        return Akkerman(a - 1, 1);
    else
        return Akkerman(a - 1, Akkerman(a, b - 1));
}
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 0)
{
    Console.WriteLine("Число не может быть отрицательным!\nВведите правильное число:");
    N = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
while (M < 0)
{
    Console.WriteLine("Число не может быть отрицательным!\nВведите правильное число:");
    M = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Фунцкия Аккермана({N},{M}):{Akkerman(N, M)}");
