//Поэлементное произведение 2-х матриц
void InputMatrix(int[,] matrix)
{
    int start = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = start++;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    for (int j = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = start++;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}



void PrintArray(int[,] matrix)
{
    for (int a = 0; a < matrix.GetLength(0); a++)
    {
        for (int b = 0; b < matrix.GetLength(1); b++)
        {
            Console.Write(matrix[a, b] + "\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,] matrix1 = new int[4, 4];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix1);
