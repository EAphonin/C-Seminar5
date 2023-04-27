// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.​
int size = GetUserNumber("Введите количество элементов в массиве: ", "Ошибка ввода, введите число");
int[] array = GetArray(size, 100, 999);
int result = AmountEvenNumbers(array);

PrintArray(array);
PrintResult(result);

int AmountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
            count++;
    }
    return count;
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

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

void PrintResult(int result)
{
    Console.WriteLine($" Количество четных элементов в массиве -> {result} ");
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