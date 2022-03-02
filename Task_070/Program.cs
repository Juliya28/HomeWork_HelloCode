// 70.	Найти сумму цифр числа.

Console.Clear();
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());

int summ = 0;
int SummFind(int num)
{
    if (num % 10 > 0)
    {
        summ += num % 10;
        SummFind(num / 10);
    }
    return summ;
}
Console.WriteLine();
Console.WriteLine($"Сумма цифр числа = {SummFind(m)}");