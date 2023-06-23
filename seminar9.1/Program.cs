/*Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
который выведет все натуральные числа кратные 3-ём в промежутке от M до N. 
M = 1; N = 9. -> "3, 6, 9"*/

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void NumbersDividableByThree(int start, int end)
{
    if(start > end) return;
    if (start %3 == 0) Console.WriteLine($"{start}");
    start++;
    NumbersDividableByThree(start,end);
}

void Problem64()
{
    int start = Input("Please enter the starting number:");
    int end = Input("Please enter the ending number:");
    NumbersDividableByThree(start,end);
}

Problem64();