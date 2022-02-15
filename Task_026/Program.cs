// 26.	Возведите число А в натуральную степень B используя цикл.

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число, в степенень которого хотите возвести первое число: ");
Console.WriteLine();
int num2 = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 1; i <= num2; i++)
{
    result *= num1;
}
Console.WriteLine($"Число возведенное в степень: " + result);
Console.WriteLine();
