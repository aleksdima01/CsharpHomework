//Возведение числа А в степень В
Console.Clear();
Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < B; i++)
{
    result = result* A;
}
Console.WriteLine($"Ваше число {A} в степени {B} =\n{result} ");