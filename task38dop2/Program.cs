
void inArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

Console.WriteLine("Введите количество элементов массива от 1 до 31:");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1 || N > 31)
{
    Console.WriteLine("Введите правильное количество элементов:");
    N = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[N];
inArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int index2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
        index2++;
}

int index3 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        index3++;
}
int[] array2 = new int[index2];
int[] array3 = new int[index3];

index2 = 0;
index3 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        array2[index2] = array[i];
        index2++;
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        array3[index3] = array[i];
        index3++;
    }
}
Console.WriteLine($"[{string.Join(", ", array2)}]");
Console.WriteLine($"[{string.Join(", ", array3)}]");
if (index3 >= index2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");