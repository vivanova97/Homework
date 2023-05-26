int InputNumber (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Task1()
{
    int num1 = InputNumber("Enter a three-digit number:");
    if (num1>999 || num1<100)
    {
        Console.WriteLine("Error: Enter a three-digit number");
        return;
    }
    int num2 = ((num1 %100)/10);
    Console.WriteLine($"The second number in {num1} is {num2}");
}

//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Task2()
{
    int num = InputNumber("Enter a number:");
    if (num < 100) Console.WriteLine("There is no third number.");
    else
    {
        while (num > 999)
        {
            num /=10;
        }
        Console.WriteLine($"The third number is {num %10}");
    }
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Task3()
{
    Dictionary<int, string> NumToWeekday = new Dictionary<int, string>()
    {
        {1, "Monday"},
        {2, "Tuesday"},
        {3, "Wednesday"},
        {4, "Thursday"},
        {5, "Friday"},
        {6, "Saturday"},
        {7, "Sunday"}
    };

    int WeekNum = InputNumber("Enter a number between 1-7 to see if it's the weekend:");
    if (WeekNum > 7) Console.WriteLine("Error: Enter a number between 1-7.");
    else if (WeekNum < 6) Console.WriteLine($"It is not the weekend. It's {NumToWeekday[WeekNum]}.");
    else if (WeekNum >= 6) Console.WriteLine ("Yay! It's the weekend!");
}


// Выполнение второй задачи, нахождение третьего числа используя массивы (для себя).
// string numStr = Console.ReadLine();
// char[] numArr = numStr.ToArray();
// Console.WriteLine(numArr[2]);









