//Упорядочить строки по убыванию
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
void SortRows(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }
        Sort(row);
        Insert(i, row, matrix);
    }
    PrintArray(matrix);
}
void Sort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}
void Insert(int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
        dest[dim, k] = source[k];
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
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0] <= 0 || coord[1] <= 0)
{
    Console.Write("Вы ошиблись!\nВведите размер матрицы: ");
    coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix);
Console.WriteLine("Отсортированный по строкам массив");
SortRows(matrix);