Console.Clear();
Console.WriteLine("Введите количество чисел, сколько будете вводить:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count = 0;
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите число {i + 1}:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Введено положительных чисел: {count}");