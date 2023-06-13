

// //For seminar4
int InputNumber (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
};

void Problem1()
{
    // Задача 25: Используя определение степени числа, напишите цикл, 
    //который принимает на вход два натуральных числа (A и B) 
    // и возводит число A в степень B.
    int BaseNum = InputNumber("Enter the base number: ");
    int ExponentNum = InputNumber("Enter the exponent number: ");
    int result = BaseNum;
    for (int i = 2; i <= ExponentNum; i++)
    { 
        result = result * BaseNum;
    }
    Console.WriteLine($"{BaseNum} ^{ExponentNum} = {result}");
}

void Problem2()
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
{
    int num = InputNumber("Enter a number: ");
    int NumDigits = 0;
    while (num > 0)
    {
        num /= 10;
        NumDigits++;
    }
    Console.WriteLine(NumDigits);
}

//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых 
//чисел и выводит отсортированный по модулю массив.
int size = 8;
int[] array = new int[size];
Random randNum = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = randNum.Next(1,100);
    Console.WriteLine($"{i} --> {array[i]}");
}

int modulo = InputNumber("Enter a module number: ");

int tempnum = 0;
for (int i = size - 1; i != 0; i--)
    {
    for (int j = size - 2; j != 0; j--){
        if (array[i]%modulo < array[j]%modulo){
            Console.Write($"{array[i]},");
        } 
    }
}
Console.Write(tempnum);








// void ClassExample() 
// {
//     using TestNamespace;

//     Animal animalVariable = new Animal();
//     animalVariable.SetVoice("Gaf");
//     animalVariable.Voice();

//     namespace TestNamespace {    
//         public class Animal 
//         {
//             protected string voice = "default voice";
//             public void Voice()
//             {
//                 Console.WriteLine(voice);
//             }

//             public void SetVoice(string voice)
//             {
//                 this.voice = voice;
//             }
//         }
//     }
// }

