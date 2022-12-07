Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива:");
    array[i] =Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");