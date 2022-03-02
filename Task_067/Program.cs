// 67.	Показать натуральные числа от N до 1, N задано.

Console.Clear();
int Rec (int n)
{
    if (n == 0) return 0;

    Console.Write(n + "  ");
    return Rec(n - 1);
}
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Rec(n);
Console.WriteLine();
