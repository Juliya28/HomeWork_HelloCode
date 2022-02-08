// 17.	По двум заданным числам проверять является ли одно квадратом другого.

Console.WriteLine("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine();

if (a2 * a2 == a1)
{
    Console.WriteLine(a1 + " Является квадратом числа " + a2);
}
else if (a1 * a1 == a2)
{
    Console.WriteLine(a2 + " Является квадратом числа " + a1);
}
else
{
    Console.WriteLine("Не являются");
}