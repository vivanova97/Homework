int size = 12;
int[] array = new int[size];
Random randNum = new Random();

//Filling array with random integers.
void FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randNum.Next(1,10);
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

//Finding the negative sum and the positive sum of the array.
void PrintNegativeSumAndPositiveSum (int [] array)
{
    int positiveIntegerSum = 0;
    int negativeIntegerSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveIntegerSum += array[i];
        else negativeIntegerSum += array[i];
    }
    Console.WriteLine($"Sum of all positive integers is {positiveIntegerSum} and sum of all negative integers is {negativeIntegerSum}");
}

//Напишите программу замены элементов массива: 
// положительные замените на соответствующие отрицательные, и наоборот.


void NegativeToPositive(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) array[i] = array[i] * -1; 
    }
}

void PositiveToNegative (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) array[i] = array[i] * -1; 
    }
}

string DoesNumExistInArray(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i]) {
            return $"{num} is in the array.";
        }
    }

    return $"{num} is not in the array.";
}

int NumOfElementsInRange (int[] array, int rangeStart, int rangeFinish)
{
    rangeFinish++;
    int numCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= rangeStart && array[i] <= rangeFinish) numCounter++;
    }
    return numCounter;
}

void FindPairs (int[] array)
{
    int[] newArray = new int[array.Length/2];
    for (int i = 0, j = array.Length -1; i < array.Length/2; i++, j--)
    {
        int newValue = array[i] * array[j];
        newArray[0] = newValue;
        Console.Write($"{newValue} ");
    }
}

FillArrayWithRandom(array);
PrintArray(array);
FindPairs(array);

