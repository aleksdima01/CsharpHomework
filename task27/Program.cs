Console.Clear();
Console.WriteLine("Введите число:");
int N1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (N1<0)
{
Console.WriteLine("Введите положительное число!");
N1 = Convert.ToInt32(Console.ReadLine());
}
while (N1>0)
{
int n=N1%10;
sum=sum+n; 
N1=N1/10;  
}

    Console.WriteLine($"Сумма цифр вашего числа:{sum}");
