//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

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

//Finding average of each column.
void AverageOfEachColumn (int[,] matrix)
{
    double sumOfRowElements = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            sumOfRowElements += matrix[i,j];
        }
    double averageOfColumn = Math.Round(sumOfRowElements/matrix.GetLength(0),2);
    Console.WriteLine($"Average for column {j} is {averageOfColumn}");
    sumOfRowElements = 0;
    }
}

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
AverageOfEachColumn(matrix);