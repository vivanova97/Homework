// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

int size = 12;
int[] array = new int[size];
Random randNum = new Random();

//Filling array with random integers.
void FillArrayWithRandom(int[] array, int startRange, int endRange)
{
    endRange++;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randNum.Next(startRange,endRange);
    }
}

//Printing array.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Finding max number in array.
int MaxNum(int[] array)
{
    int maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNum < array[i]) maxNum = array[i];
    }
    return maxNum;
}

//Finding min number in array.
int MinNum(int[] array)
{
    int minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minNum  > array[i]) minNum = array[i];
    }
    return minNum;
}

//Finding difference between the max and min number in array.
int DifferenceBetweenMaxMin(int maxNumber, int MinNumber)
{
    int difference = MaxNum(array) - MinNum(array);
    return difference;
}

FillArrayWithRandom(array, -10, 10);
PrintArray(array);
Console.WriteLine($"Maximum number: {MaxNum(array)}");
Console.WriteLine($"Minimum number: {MinNum(array)}");
Console.WriteLine($"{MaxNum(array)} - {MinNum(array)} = {DifferenceBetweenMaxMin(MaxNum(array),MinNum(array))}");
