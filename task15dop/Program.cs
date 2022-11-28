//Console.Clear();
Console.WriteLine("Введите последовательность чисел:");
int N1 = Convert.ToInt32(Console.ReadLine());
while (N1<1)
{
    Console.Write("Вы ошиблись!\nВведите правильную последовательность:");
    N1 = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
int count2 = 0;
int lastel = 0;
int N2 = 0;
while (N1>0) 
{
count++;
   N1 /= 10;
    lastel = N1 / 10;
    if (lastel % 10 == 0)
    {
        N2 = lastel;
        break;
    }
}
//Console.WriteLine($"Количество цифр вашего числа:{count}");
Console.WriteLine($"lastel:{lastel}");
Console.WriteLine($"lastel:{N2}");

while (N2 > 0)
{
    count2++;
    N2 /= 10;
    Console.WriteLine($"Количество цифр вашего числа:{count2}");
}
 Console.WriteLine($"Количество цифр вашего числа:{count2}");
int n = 0;
for (n=count2; n > 0;n--)
{

}