// 41.	Выяснить являются ли три числа сторонами треугольника.

Console.Clear();
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine();

if (a < (b + c) && b < (a + c) && c < (a + b))
{
    Console.WriteLine("Числа являются сторонами треугольник. ");
}
else
{
    Console.WriteLine("Числа не являются сторонами треугольник. ");
}