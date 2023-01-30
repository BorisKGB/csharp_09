// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbersBetween(int number1, int number2)
{
    if (number1 == number2) return number1;
    else return number1 + SumNaturalNumbersBetween(number1+1, number2);
}

Console.Write("Введите значение M > ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N, большее чем M > ");
int n = Convert.ToInt32(Console.ReadLine());

// Ensure that N always more then M
if (m > n)
{
    int tmp = m;
    m = n;
    n = tmp;
}

if (n < 0 || m < 0) Console.WriteLine("Перезапустите программу и введите положительные числа");
else Console.WriteLine($"Сумма натуральных чисел '{m}' и '{n}' равна '{SumNaturalNumbersBetween(m,n)}'");
