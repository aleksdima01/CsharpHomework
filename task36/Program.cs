//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-99, 100);
}


int ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
{
if (i%2!=0)
            sum=sum+array[i];
    }
return sum;
}

Console.Clear();
int[] array = new int[4];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма нечетных элементов массива: {ReleaseArray(array)}");