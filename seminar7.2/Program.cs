//Задача 50. Напишите программу, которая на вход 
//принимает индексы элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

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

//Returning an element of a matrix or returning "does not exist".
string ReturnElementOfMatrix (int [,] matrix)
{
    int row = Input($"Write the row index: ");
    int column = Input($"Write the column index: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            if (i == row && j == column) 
            {
                return $"{matrix[i,j]}";
            }
        }
    }
    return $"[{row},{column}] does not exist in matrix.";
}

FillMatrix(matrix,1,10);
PrintMatrix(matrix);
Console.WriteLine(ReturnElementOfMatrix(matrix));

