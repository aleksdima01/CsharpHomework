//3-х мерный массив, заполненный неповторяющимися 2-х значными числами
void InputMatrix(int[,,] matrix, int size)
{
    int[] arr = new int[size];
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100); // [10, 99]
                while (arr.Contains(matrix[i, j, k]))
                    matrix[i, j, k] = new Random().Next(10, 100);
                arr[l] = matrix[i, j, k];
                Console.WriteLine($"{matrix[i, j, k]} ({i},{j},{k}) \t");
                l++;
            }
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размер трехмерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 90)
{
    Console.Write("Значения введены некорректные!\nВведите размер трехмерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix1 = new int[size[0], size[1], size[2]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix1, size[0] * size[1] * size[2]);

