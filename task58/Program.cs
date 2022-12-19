//Поэлементное произведение 2-х матриц
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[4, 4];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
    }
    PrintArray(resultMatrix);
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
int[,] matrix2 = new int[4, 4];
Console.WriteLine("Начальный массив 1");
InputMatrix(matrix1);
Console.WriteLine("Начальный массив 2");
InputMatrix(matrix2);
Console.WriteLine("Поэлементное произведение матриц:");
ProductMatrix(matrix1, matrix2);
