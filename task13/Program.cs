Console.Clear();
Console.WriteLine("Введите число:");
int N1 = Convert.ToInt32(Console.ReadLine());
while (N1<100 && N1>-100)
{Console.Write("Вы ошиблись! В вашем числе нет третьей цифры!\nВведите верное число:");
    N1 = Convert.ToInt32(Console.ReadLine());
}

 while (N1 >= 1000||N1<=-1000)
        {
            N1 /= 10;
        }

int result = N1 % 10;
Console.WriteLine($"Третья цифра вашего числа:{Math.Abs(result)}");