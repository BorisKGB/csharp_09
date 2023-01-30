// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNaturalNumbers(int number)
{
    // error exit for numbers below 1
    if (number < 1) 
    {
        Console.Write("Incorrect number");
        return;
    }
    if (number == 1) Console.Write(number);
    else
    {
        Console.Write($"{number} ");
        PrintNaturalNumbers(number-1);
    }
}

Console.Write("Введите значение N > ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от '{n}' до '1':");
PrintNaturalNumbers(n);
Console.WriteLine();
