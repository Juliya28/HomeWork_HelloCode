// 66.	Показать натуральные числа от 1 до N, N задано.
Console.Clear();
int List (int n)
{
    if (n < 1) return 0;

    Console.Write(n + "  ");
    return List(n - 1);
}
Console.WriteLine("Введите границу интервала: ");
int n = int.Parse(Console.ReadLine());
List(n);
Console.WriteLine();
