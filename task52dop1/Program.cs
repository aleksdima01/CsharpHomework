//Отраженная по горизонтали матрица
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
while (coord[0] <= 0 || coord[1] <= 0 || coord[0] > 100 || coord[1] > 100)
{
    Console.WriteLine("Размер не может быть нулевым,отрицательным или превышать 100! Введите правильный размер:");
    coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
}
Console.WriteLine(" ");
int[,] array = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputArray(array);
Console.WriteLine(" ");
void Transporation(int[,] array)
{
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp = array[i, j];
            array[i, j] = array[array.GetLength(0) - i - 1, j];
            array[array.GetLength(0) - i - 1, j] = tmp;
        }
    }
}
Transporation(array);
Console.WriteLine("Отраженная по горизонтали матрица:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} \t");
    Console.WriteLine();
}