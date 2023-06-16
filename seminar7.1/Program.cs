//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами, 
//округлёнными до одного знака.

//Inputting a number.
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Filling matrix with random numbers.
void FillMatrix(double[,] matrix, int minValue, int maxValue)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i,j] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
}

//Printing matrix.
void PrintMatrix (double[,] matrix)
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

//Creating matrix.
int numberOfRows = Input("Please enter the number of rows: ");
int numberOfColumns = Input("Please enter the number of columns: ");
double[,] matrix = new double[numberOfRows,numberOfColumns];

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);