/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/


int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}


int recursion(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return recursion(n - 1, 1);
    }
    else
    {
        return recursion(n - 1, recursion(n, m - 1));
    }
}


int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
Console.WriteLine(recursion(n, m));