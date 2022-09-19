// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void GetNumbers(int num1, int num2)
{
    int max = num1;
    int min = num2;
    if (max < num2)    
    {
        max = num2;
        min = num1;
    }
    while (min < max)
    {
        Console.Write($"{min}, ");
        min++;
    }
    if(min==max) Console.Write(max);
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();
GetNumbers(m, n);