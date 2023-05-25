void Task1()
{
    // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.WriteLine("Enter first number:");
    Double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    Double num2 = Convert.ToDouble(Console.ReadLine());
    if (num1 > num2)
    {
        Console.WriteLine($"{num1} is greater than {num2}");
    }
    else
    {
        Console.WriteLine(($"{num1} is less than {num2}"));
    };  
}


void Task2()
{
    //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.WriteLine("Enter first number:");
    Double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    Double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter third number:");
    Double num3 = Convert.ToDouble(Console.ReadLine());

    Double MaxNum = num1;

    if (num2 > MaxNum)
    {
        MaxNum = num2;
        }
    if (num3 > MaxNum)
    {
        MaxNum = num3;
    }
    Console.WriteLine($"The maximum number is {MaxNum}");
};

void Task3()
{
    //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    Console.WriteLine("Enter a number:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num %2 == 0 )
    {
        Console.WriteLine($"{num} is an even number.");
    }
    else
    {
        Console.WriteLine($"{num} is NOT an even number.");
    };
};

void Task4()
{
    //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    Console.WriteLine("Enter a number greater than 1:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = 2;
    if (num1 > 1)
    {
        while (num1 >= num2)
        {
            Console.WriteLine(num2);
            num2 += 2;
        }
    }
    else 
    { 
        Console.WriteLine("Error: Enter a number greater than 1");
    };
}

int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = InputNumber("Enter a number:");
int num2 = InputNumber("Enter a number:");
if (num1 * num1 == num2 || num2 *num2 == num1) Console.WriteLine($"{num1} is dividable by 7 and 23");
else Console.WriteLine($"Некратно 7 and 23");



