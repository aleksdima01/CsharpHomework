//3-х мерный массив, заполненный неповторяющимися 2-х значными числами
void InputMatrix(int[,,] matrix)
{
    int[] arr = new int[8];
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
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) \t");
                l++;
            }
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,,] matrix1 = new int[2, 2, 2];
Console.WriteLine("Начальный массив");
InputMatrix(matrix1);

