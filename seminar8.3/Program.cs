//Задача 58. Напишите программу, которая заполнит спирально массив 4 на 4.

//Inputing a number.
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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

//Filling matrix in spiral form.
int[,] SpiralFill(int[,] matrix)
{
    int i;
    int k = 0;
    int l = 0;
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    //k - starting row index
    //m - ending row index
    //l - starting column index
    //n - ending column index
    //i - iterator
    int sum = 0;
    while (k < m && l < n)
    {
        //Printing first row from remaining rows
        for (i = l; i < n; i++)
        {
            matrix[k,i] = sum;
            sum++;
        }
        k++;
        //Printing the last column
        for (i = k; i < m; i++)
        {
            matrix[i, n-1] = sum;
            sum++;
        }
        n--;
        if (k < m)
        {
            for (i = n-1; i >= l; i--)
            {
                matrix[m-1,i] = sum;
                sum++;
            }
            m--;
        }
        if (l < n)
        {
            for (i = m-1; i >=k; i--)
            {
                matrix[i,l] = sum;
                sum++;
            }
            l++;
        }
    
    }
    return matrix;
}

//Create matrix.
int numberOfRows = Input("Please enter the number of rows: ");
int numberOfColumns = Input("Please enter the number of columns: ");
int[,] matrix = new int[numberOfRows,numberOfColumns];

//Printing empty matrix.
PrintMatrix(matrix);
Console.WriteLine();
//Printing matrix filled in spiral form.
SpiralFill(matrix);
PrintMatrix(matrix);
