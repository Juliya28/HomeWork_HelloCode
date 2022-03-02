// 68.	Показать натуральные числа от M до N, N и M заданы.

Console.Clear();
void List (int m, int n)
{
    if (m > n)
    {
        List(m - 1, n);
    }
    else if (m < n)
    {
        List(m + 1, n);
    }
    Console.Write(m + "  ");
}
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
List(n, m);
Console.WriteLine();
