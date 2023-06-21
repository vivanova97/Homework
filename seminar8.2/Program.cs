// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Inputing a number.
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Filling matrix with random numbers.
void FillMatrix(int[,] matrix, int startRange, int endRange)
{
    endRange++;
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i,j] = random.Next(startRange,endRange);
        }
    }
}

//Printing matrix.
void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}

//Create matrix.
int numberOfRows = Input("Please enter the number of rows: ");
int numberOfColumns = Input("Please enter the number of columns: ");
int[,] matrix = new int[numberOfRows,numberOfColumns];

//Finding row with the lowest sum. 
// !! Здесь ввывод для пользователя, то-есть ввыводится номер строки а не индекс 
void RowWithLowestSum(int[,] matrix)
{
    int sum = 0;
    int previousSum = 0;
    int lowestSum = 0;
    int lowestSumRowNum = 0;
     for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            sum += matrix[i,j];
            previousSum += matrix[i-1, j]; 
        }
        if (sum < previousSum) 
        {
            lowestSum = sum;
            lowestSumRowNum = i+1; //Ввывод для пользователя, ввыводится номер строки а не индекс.
        }
        else 
        {
            lowestSum = previousSum;
            lowestSumRowNum = i;
        }
        sum = 0;
        previousSum = 0;
    }
    Console.WriteLine($"The row with the lowest sum is row {lowestSumRowNum}");
}

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
RowWithLowestSum(matrix);
