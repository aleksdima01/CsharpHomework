//Gоиск строки с наименьшей суммой эл-ов
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void SummRows(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            row[i] = row[i] + matrix[i, j];
    }
    Console.WriteLine($"Сумма эл-ов по строкам: {string.Join(", ", row)}");
    int min = row.Min();
    int index = Array.IndexOf(row, min);
    Console.WriteLine($"Строка с наименьшей суммой эл-ов:{index + 1}");
}
Console.Clear();
Console.Write("Введите прямоугольную матрицу: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0] == coord[1])
{
    Console.Write("Вы ошиблись!\nВведите прямоугольную матрицу: ");
    coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix);
SummRows(matrix);