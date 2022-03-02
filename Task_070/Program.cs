// 70.	Найти сумму цифр числа.

Console.Clear();
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());

int SummFind(int num)
{
    if (num > 0)
    {
        return SummFind(num / 10) + num % 10;
    }
    return 0;
}
Console.WriteLine();
Console.WriteLine($"Сумма цифр числа = {SummFind(m)}");