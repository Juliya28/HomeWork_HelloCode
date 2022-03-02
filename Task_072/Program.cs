// 72.	Написать программу возведения числа А в целую стень B.

Console.Clear();
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int PowNum(int a, int b)
{
    if (b == 1) return a;
    else return a * PowNum(a, b - 1);
}
Console.WriteLine("===================");
Console.WriteLine($"Число {a} возведено в степень {b} = {PowNum(a, b)}");
Console.WriteLine();