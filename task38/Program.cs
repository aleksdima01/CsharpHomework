//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(new Random().NextDouble()*(8+8)-8,3);
}

double ReleaseArray(double[] array)
{
    double max = 0;
    double min = 0;
    double result = 0;
    Array.Sort(array);
    max = array[array.Length - 1];
    min = array[0];
    result = max - min;
    return result;
}
Console.Clear();
double[] array = new double[8];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {ReleaseArray(array)}");