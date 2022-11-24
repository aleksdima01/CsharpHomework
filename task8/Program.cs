Console.Clear();
int r = 0;
Console.WriteLine("Введите число от 1 до N:");
int N1 = Convert.ToInt32(Console.ReadLine());
while (N1 < 1)
{
    Console.Write("Вы ошиблись!\nВведите верное число:");
    N1 = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= N1; i++)
{
    if (i % 2 == 0)
    {
        r = i;
        Console.Write(r + " ");
    }
}
