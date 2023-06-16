//Inputing a number.
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Create matrix.
void Problem1()
{
    int numberOfRows = Input("Please enter the number of rows: ");
    int numberOfColumns = Input("Please enter the number of columns: ");
    int[,] matrix = new int[numberOfRows,numberOfColumns];
    FillMatrix(matrix, 1, 5);
    PrintMatrix(matrix);
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (i == j) sum += matrix[i,j];
        }
    }
    Console.WriteLine(sum);
    Console.WriteLine();
}
Problem1();
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


