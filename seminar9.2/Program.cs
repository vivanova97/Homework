/*Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
который найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120*/

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumofElements(int start, int end, int sum = 0)
{
if (start > end) 
    {   
        return sum;
    }
sum += start;
start++;
return SumofElements(start, end, sum);
}

void Problem66()
{
    int start = Input("Enter the starting number:");
    int end = Input("Enter the ending number:");
    int result = SumofElements(start, end);
    Console.WriteLine($"The sum of elements from {start} to {end} is {result}.");
}

Problem66();
