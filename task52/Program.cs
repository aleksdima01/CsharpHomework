//Вывод среднего арифметического каждого столбца
void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
Console.WriteLine(" ");
void AvgSearch(int[,] array)
{
    double result = 0;
    Console.WriteLine("Ср.арифметическое столбцов:");
    for (int i = 0; i < array.GetLength(1); i++)
    {

        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array[j, i];

        }
        result = result / array.GetLength(0);
        Console.Write($"{result}\t");
        result = 0;
    }
}
AvgSearch(array);
