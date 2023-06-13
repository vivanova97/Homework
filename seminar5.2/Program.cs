// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.

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

//Finding sum of odd integers in an array.
int OddIntSum(int[] array)
{
    int oddIntSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 1) oddIntSum += array[i];
    }
    return oddIntSum;
}

FillArrayWithRandom(array, 1, 10);
PrintArray(array);
Console.WriteLine($"The sum of odd integers in the array is {OddIntSum(array)}");
