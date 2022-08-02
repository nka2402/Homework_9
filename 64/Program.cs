/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
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

int NaturalNumber(int n, int m)
{
    Console.Write($"{m} ");
    if (n != m)
    {
        NaturalNumber(n, m + 1);
    }
    return m;
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");

int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}

NaturalNumber(n, m);
