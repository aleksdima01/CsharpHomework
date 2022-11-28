Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int N1 = Convert.ToInt32(Console.ReadLine());
while ((N1<-999 || N1>-100) && (N1<100 || N1>999))
{Console.Write("Вы ошиблись!\nВведите верное число:");
    N1 = Convert.ToInt32(Console.ReadLine());
}
int result = N1 % 100 / 10;
if (result<0)
Console.WriteLine($"Вторая цифра вашего числа:{result*-1}");
else
Console.WriteLine($"Вторая цифра вашего числа:{result}");