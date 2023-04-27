// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.​
int size = GetUserNumber("Введите количество элементов в массиве: ", "Ошибка ввода, введите число");
double[] array = GetArray(size, 0, 1);
double min = GetMinNumber(array);
double max = GetMaxNumber(array);
double result = GetDifference(min, max);

PrintArray(array);
PrintResult(result, min, max);

double GetDifference(double min, double max)
{
    double res = max - min;
    return res;
}

double GetMaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double GetMinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
    return arr;
}

void PrintResult(double result, double min, double max)
{
    Console.WriteLine($" Минимальное значение {min}, максимальное значение {max} -> {result} ");
}

void PrintArray(double[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}