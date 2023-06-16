// int size = 12;
// int[] array = new int[size];
// Random randNum = new Random();

//Filling array with random integers.

// void FillArrayWithRandom(int[] array, int startRange, int endRange)
// {
//     endRange++;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = randNum.Next(startRange,endRange);
//     }
// }

//Printing array.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//User integer input.
int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// //Reverse the order of an array.
// int[] ReverseArrayOrder (int[] array)
// {
//     int maxIndex = array.Length -1;
//     for (int i = 0; i < (array.Length/2); i++)
//     {
//         int temp1 = array[i];
//         int temp2 = array[maxIndex -i];
//         array[i] = temp2;
//         array[maxIndex -i] = temp1;
//     }
//     return array;
//     Console.WriteLine();
// }

//Can three sides form a triangle?
// void IsItATriangle() 
// {
//     int sideA = Input("Write first number: ");
//     int sideB = Input("Write second number: ");
//     int sideC = Input("Write third number: ");
//     if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
//     {
//         Console.WriteLine("Is triangle");
//     }
//     else Console.WriteLine("Is not triangle");
// }

//Fibonacci
// int[] Fibonacci ()
// {
//     int size = Input("Enter a number: ");
//     int[] array = new int[size];
//     array[1] = 1;
//     for (int i = 2; i < size; i++)
//     { 
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// }

// Console.WriteLine(string.Join(",",Fibonacci()));

// Fill new array with numbers from another array.
// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int [array.Length];
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }

// FillArrayWithRandom(array,1,10);
// PrintArray(array);
// Console.WriteLine(string.Join(",",CopyArray(array)));

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] ArrayInput()
{   int size = Input("Enter the array length: ");
    int[] array =  new int[size];
    for (int i = 1; i < size; i++)
    {   
        array[i-1] = Input($"Enter the {i} element in array:");
    }
    return array;
}

void PrintArray1 ()
{
    Console.WriteLine(string.Join(",", ArrayInput()));
}

int CountNumsInArrayGreaterThan0(int [] array)
{
    int counter = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}



Console.WriteLine(CountNumsInArrayGreaterThan0(ArrayInput()));
PrintArray1();