Console.Clear();
Console.WriteLine("Введите количество кустов на грядке:");
int N1 = Convert.ToInt32(Console.ReadLine());
int i = 0;
int result = 0;
int[] numbers = new int[N1];
while (i < N1)
{
    Console.WriteLine($"Введите количество ягод на {i + 1} кусте:");
    int N2 = Convert.ToInt32(Console.ReadLine());
    numbers[i] = N2;
    i++;
}

//Console.WriteLine(" ");
for (i = 1; i < numbers.Length - 1; i++)
{
    if (result < numbers[i - 1] + numbers[i] + numbers[i + 1])
        result = numbers[i - 1] + numbers[i] + numbers[i + 1];
}
if (result < numbers[N1 - 1] + numbers[N1 - 2] + numbers[0])
    result = numbers[N1 - 1] + numbers[N1 - 2] + numbers[0];
if (result < numbers[0] + numbers[1] + numbers[N1 - 1])
    result = numbers[0] + numbers[1] + numbers[N1 - 1];
Console.WriteLine(result);