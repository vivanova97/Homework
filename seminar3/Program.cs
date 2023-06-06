int InputNumber (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Problem1()
{
    Console.Write("Enter a 5-digit number: ");
    string num = Console.ReadLine();
    int ln = num.Length;
    int center = ln/2;

    for (int i = 0, length = ln - 1; i < center; i++, length--) 
    {
        if (num[i] != num[length]) 
        {
            Console.WriteLine($"The number {num} is not a polyndrom.");
            return;
        }
    }

    Console.WriteLine($"The number {num} is polyndrom");
}
    

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Problem2()
{
    Console.WriteLine("Problem #2");
    int x1 = InputNumber("Enter x1: ");
    int y1 = InputNumber("Enter y1: ");
    int z1 = InputNumber("Enter z1: ");
    int x2 = InputNumber("Enter x2: ");
    int y2 = InputNumber("Enter y2: ");
    int z2 = InputNumber("Enter z2: ");
    double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    result = Math.Round(result,2);
    Console.WriteLine($"Rounded to the nearest tenth, the distance between the points ({x1},{y1},{z1}) and ({x2},{y2},{z2}) is {result}");
}

//3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Problem3() 
{
    Console.WriteLine("Problem #2");
    int N = InputNumber("Enter a number: ");

    if (N > 0)
    {
        for (int i = 1; i <= N; i++)
        {
            double result = Math.Pow(i, 3);
            Console.WriteLine($"{i}^3 = {result}");
        }
    }
    else 
    {
        Console.WriteLine("Error: Enter a number greater than zero.");
    }
}


