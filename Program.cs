// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Task34Array = GetArray(10, 100, 999);
Console.WriteLine($"In array [{String.Join(" ", Task34Array)}] {EvenNumInArrayCount(Task34Array)} even numbers");
Console.WriteLine();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Task36Array = GetArray(10, -9, 9);
int Task36GetSum = GetSumOfUnevenPositions(Task36Array);
Console.WriteLine($"In array [{String.Join(" ", Task36Array)}] the Sum of elements with uneven index is {Task36GetSum}");
Console.WriteLine();

// Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем).
// Найдите разницу между максимальным и минимальным элементов массива.

int[] Task38Array = GetArray(10, -100, 100);
int Task38GetMax = FindMaxInArray(Task38Array);
int Task38GetMin = FindMinInArray(Task38Array);
int diff = Task38GetMax - Task38GetMin;
Console.WriteLine($"In array [{String.Join(" ", Task38Array)}] difference between max and min numbers is {diff}");

//Block of methods

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenNumInArrayCount (int[] SomeArray)
{
    int counter = 0;
    for (int i = 0; i < SomeArray.Length; i++)
    {
        if (SomeArray[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

int GetSumOfUnevenPositions (int[] SomeArray)
{
    int Sum = 0;
    for (int i = 1; i < SomeArray.Length; i += 2)
    {
        Sum = Sum + SomeArray[i];
    }
    return Sum;
}

int FindMaxInArray (int[] SomeArray)
{
    int max = SomeArray[0];
    for (int i = 0; i < SomeArray.Length; i ++)
    {
        if (max < SomeArray[i])
        {
            max = SomeArray[i];
        }
    }
    return max;
}

int FindMinInArray (int[] SomeArray)
{
    int min = SomeArray[0];
    for (int i = 0; i < SomeArray.Length; i ++)
    {
        if (min > SomeArray[i])
        {
            min = SomeArray[i];
        }
    }
    return min;
}