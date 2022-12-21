//Вывести первые N строк треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.
int factorial(int count)
{
    int x = 1;
    for (int i = 1; i <= count; i++)
    {
        x *= i;
    }
    return x;
}

void Triangle(int count)
{
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j <= (count - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int count = Convert.ToInt32(Console.ReadLine());
Triangle(count);