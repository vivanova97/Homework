/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A (int m, int n)
{
    if (m == 0) 
    {
        return n+1;
    }
    else if (n == 0)
    {
        return A(m-1, 1);
    }
    else 
    {
        return A(m-1, A(m,n-1));
    }
}

void Problem68 ()
{
    int m = Input("Enter the first number: ");
    int n = Input("Enter the second number: ");
    Console.WriteLine($"A({m},{n}) = {A(m,n)}");
}

Problem68();
