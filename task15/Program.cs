Console.Clear();
Console.WriteLine("Введите день недели 1-7:");
int N1 = Convert.ToInt32(Console.ReadLine());
while (N1<1 || N1>7)
{Console.Write("Вы ошиблись! Такого дня недели не существует!\nВведите верный день недели:");
    N1 = Convert.ToInt32(Console.ReadLine());
}

if (N1>0&&N1<6)
Console.WriteLine("Будний день!");
else 
Console.WriteLine("Выходной!");