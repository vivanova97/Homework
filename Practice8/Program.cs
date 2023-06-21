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

int [,] ReplaceColumnsWithRows (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++) 
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] =  temp;
        }
    }  
    Console.WriteLine();
    return matrix; 
} 

void ChangePlaces (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = temp;
        Console.WriteLine();
    }
}

int[] Dictionary(int[,] matrix, int size)
{
    int[] dictionary = new int[size];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i,j];
            dictionary[temp]++;
        }
    }
    return dictionary;
}
    
int[,] DeleteColumnAndRowofLowestNumber (int[,] matrix)
{
    int min = matrix[0,1];
    int minIndexi = 0;
    int minIndexj = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min) 
            {
                min = matrix[i,j];
                minIndexi = i;
                minIndexj = j;
            }

        }
    }

    int[,] newMatrix = new int[numberOfRows-1, numberOfColumns-1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        bool foundRow = false;
        if (i != minIndexi) 
        {
            bool foundColumn = false;
            for (int j = 0; j <matrix.GetLength(1); j++)
            {
                int newColumnIndex = foundColumn ? j-1 : j;

                if (foundRow && j != minIndexj) 
                {
                    newMatrix[i-1,newColumnIndex] = matrix[i,j];
                } else if (j != minIndexj) 
                {
                    newMatrix[i,newColumnIndex] = matrix[i,j];
                } else foundColumn = true;
            }
        } else foundRow = true;
    }

    return newMatrix;
}


FillMatrix(matrix,1,10);
PrintMatrix(matrix);
PrintMatrix(DeleteColumnAndRowofLowestNumber(matrix));


