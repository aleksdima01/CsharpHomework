void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-7, 7);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер двумерного массива:");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
while (coord[0] <= 0 || coord[1] <= 0)
{
    Console.WriteLine("Размер не может быть нулевым или  отрицательным! Введите правильный размер:");
    coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
}
int[,] array = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputArray(array);
void AvgSearch(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < length; j++)
        {
            result = result + array[i, j];

        }
        Console.WriteLine(result);
    }
}
AvgSearch(array);
