// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.​
int size = GetUserNumber("Введите количество элементов в массиве: ", "Ошибка ввода, введите число");
int minValue = GetUserNumber("Введите минимальный диапозон значений массива: ", "Ошибка ввода, введите число");
int maxValue = GetUserNumber("Введите максимальный диапозон значений массива: ", "Ошибка ввода, введите число");
int[] array = GetArray(size, minValue, maxValue);
int result = SumOddNumbers(array);

PrintArray(array);
PrintResult(result);

int SumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

void PrintResult(int result)
{
    Console.WriteLine($" Сумма элементов стоящих на нечетных позициях -> {result} ");
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
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