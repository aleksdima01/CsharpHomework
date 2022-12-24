//Заполнение массива спиралью
void InputMatrix(int[,] matrix)
{
    int i = 0;
    int j = 0;
    int number = 1;
    while (number <= 4 * 4)
    {
        matrix[i, j] = number;
        if (i <= j + 1 && i + j < 4 - 1)
            j++;
        else if (i < j && i + j >= 4 - 1)
            i++;
        else if (i >= j && i + j > 4 - 1)
            j--;
        else
            i--;
        number++;
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
Console.WriteLine("Начальный массив, заполненный спиралью:");
InputMatrix(matrix1);
PrintArray(matrix1);