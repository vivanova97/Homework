//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
//задаются пользователем.

//User integer input.
int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Finding crossing point between two lines.
string CrossingPoint()
{
    int b1 = Input("Enter b1:");
    int k1 = Input("Enter k1:");
    int b2 = Input("Enter b2:");
    int k2 = Input("Enter k2:");
    int x = (b2 - b1)/ (k2 - k1);
    int y = (k1 * x) + b1;
    string result = $"The lines intersect at ({x},{y})";
    return result;
}

Console.WriteLine(CrossingPoint());