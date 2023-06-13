// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

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

//Finding the number of even numbers.
int CountEvenNumbersInArray(int[] array)
{
    int countEvenNums = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) countEvenNums++;
    }
    return countEvenNums;
}

FillArrayWithRandom(array, 100, 999);
PrintArray(array);
Console.WriteLine($"The number of even integers in the array is {CountEvenNumbersInArray(array)}");
