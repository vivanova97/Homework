//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Each row from greatest to least.
int[,] RowElementsGreatestToLeast(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) -1; j++) 
            {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if (matrix[i,k] < matrix[i,k+1]) 
                    {
                        (matrix[i,k], matrix[i,k+1]) = (matrix[i,k+1], matrix[i,k]);
                    }
                }
            }
        }
    return matrix;
}
  


//Create matrix.
int numberOfRows = Input("Please enter the number of rows: ");
int numberOfColumns = Input("Please enter the number of columns: ");
int[,] matrix = new int[numberOfRows,numberOfColumns];


FillMatrix(matrix,1,10);
PrintMatrix(matrix);
RowElementsGreatestToLeast(matrix);
Console.WriteLine();
PrintMatrix(matrix);