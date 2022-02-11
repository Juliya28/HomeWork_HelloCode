// 26.	Возведите число А в натуральную степень B используя цикл.

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число, в степенень которого хотите возвести первое число: ");
Console.WriteLine();
int num2 = int.Parse(Console.ReadLine());

int result = 0;
for (int i = 0; i <= num2; i++)
{
    result = num1*num1;
}
Console.WriteLine();
Console.WriteLine($"Число возведенное в степень: " + result);