// 25.	Найти сумму чисел от 1 до А.

Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Числа от 1 до А: " + "\t");
Console.WriteLine();

int summ = 0;
for (int i = 1; i <= num; i++)
{
    Console.Write($"{i}" + "\t");
}
Console.WriteLine();
for (int i = 1; i <= num; i++)
{
    summ = summ + i;
}
Console.WriteLine();
Console.WriteLine("Сумма чисел от 1 до А: " + summ);
Console.WriteLine();
