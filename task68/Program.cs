// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Определение алгоритма из Википедии:
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Ackermann(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Ackermann(m-1, 1);
    else return Ackermann(m-1, Ackermann(m, n-1));
}

Console.Write("Введите значение M > ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N > ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат работы функции с параметрами m={m}, n={n} -> '{Ackermann(m,n)}'");
