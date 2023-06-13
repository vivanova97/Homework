// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

int size = 12;
decimal[] array = new decimal[size];
Random randNum = new Random();

//Filling array with random integers.
void FillArrayWithRandom(decimal[] array, double startRange, double endRange)
{
    endRange++;
    for (int i = 0; i < array.Length; i++)
    {
        decimal newValue = new decimal(randNum.NextDouble());
        array[i] = Math.Round(newValue * 100, 2);
    }
}

//Printing array.
void PrintArray(decimal[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

//Finding max number in array.
decimal MaxNum(decimal[] array)
{
    decimal maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNum < array[i]) maxNum = array[i];
    }
    return maxNum;
}

//Finding min number in array.
decimal MinNum(decimal[] array)
{
    decimal minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minNum  > array[i]) minNum = array[i];
    }
    return minNum;
}

//Finding difference between the max and min number in array.
decimal DifferenceBetweenMaxMin(decimal maxNumber, decimal MinNumber)
{
    decimal difference = maxNumber - MinNumber;
    return difference;
}

FillArrayWithRandom(array, -10, 10);
PrintArray(array);
Console.WriteLine($"Maximum number: {MaxNum(array)}");
Console.WriteLine($"Minimum number: {MinNum(array)}");
Console.WriteLine($"{MaxNum(array)} - {MinNum(array)} = {DifferenceBetweenMaxMin(MaxNum(array),MinNum(array))}");
