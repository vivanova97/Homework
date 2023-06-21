[7, 1, 9, 7, 3, 0, 7, 8, 9, 10]

int[] BubbleSort(int[] inArray)
{
    int arrLength = inArray.Length - 1;

    for (int i = 0; i < arrLength; i++)
    {
        for (int j = 0; j < arrLength - i; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
    }

    return inArray;
}

void FillArrayWithRandom(int[] array)
{
    Random randNum = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randNum.Next(1,10);
    }
}

int[] testArray = new int[10];
FillArrayWithRandom(testArray);
Console.WriteLine(String.Join(", ", BubbleSort(testArray)));
