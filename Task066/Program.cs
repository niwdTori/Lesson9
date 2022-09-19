// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void GetSumNumbers(int num1, int num2)
{
    int max = num1;
    int min = num2;
    int sum = 0;
    if (max < num2)    
    {
        max = num2;
        min = num1;
    }
    while (min <= max)
    {
        sum += min;
        min++;
    }
    Console.WriteLine($"Сумма элементов: {sum}");
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();
GetSumNumbers(m, n);