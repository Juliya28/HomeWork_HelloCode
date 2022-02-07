// 13.	Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число: ");
int a1 = int.Parse(Console.ReadLine());
int a2 = 4;

if (a1 % a2 == 0)
{
    Console.WriteLine(a1 + " Кратно " + a2);
}
 else
{
    Console.WriteLine(a1 + " Не кратно " + a2 + " Остаток от деления " + a1 % a2);
}
