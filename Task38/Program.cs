// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

void InputArray(double[] array)
{
    int end = 30, begin = 10;
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}

double MaxNumber(double[] array)
{
    double max = 0;
    foreach (double element in array)
    {
        if (element > max)
            max = element;
    }
    return max;
}
double MinNumber(double[] array)
{
    double min = 0;
    foreach (double element in array)
    {
        if (min == 0 || element < min)
            min = element; 
    }
    return min;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
double max = MaxNumber(array);
double min = MinNumber(array);
double diff = Math.Round(max - min, 2);
Console.WriteLine($"Разница между максимальным и минимальным значениями равна: {max} - {min} = {diff}");

