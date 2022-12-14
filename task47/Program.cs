void InputArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*(10+10) - 10,3);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер двумерного массива:");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
while(coord[0]<=0|| coord[1]<=0)
{
    Console.WriteLine("Размер не может быть нулевым или  отрицательным! Введите правильный размер:");
    coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
}
double[,] array = new double[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputArray(array);