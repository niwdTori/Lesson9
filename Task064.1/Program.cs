// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


void GetNumbers(int num1, int num2)
{
    if(num1 == num2+1) return;
    Console.WriteLine(num1);
    GetNumbers(num1+1,num2);
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());


Console.WriteLine();
GetNumbers(m, n);