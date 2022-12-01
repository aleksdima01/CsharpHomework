//Таблица кубов введенного числа
Console.Clear();
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
 Console.WriteLine("Ваша таблица кубов:");
for (int i=1; i <= N; i++)
{
    result = (int)Math.Pow(i, 3);
    Console.WriteLine(result);
}