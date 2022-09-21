// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSumNumbers(int num1, int num2)
{
    int sum = num1;
    if (num1==num2) return sum;
    sum += GetSumNumbers(num1 + 1, num2);
    return sum;
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();
int result = GetSumNumbers(m, n);
Console.WriteLine($"Сумма элементов: {result}");