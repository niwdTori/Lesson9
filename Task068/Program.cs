// //Напишите программу вычисления функции Аккермана с помощью рекурсии.

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return A(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return A(m - 1, A(m, n - 1));
    }
    return 0;
}

Console.WriteLine("Введите число N: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 <= 0 || number2 <= 0)
{
    Console.WriteLine("Числа должны быть больше 0!");
    return;
}

int result = A(number1, number2);
Console.WriteLine(result);
