// 19.	Определить номер четверти плоскости, в которой находится точка 
// с координатами Х и У, причем X ≠ 0 и Y ≠ 0.

Console.WriteLine("Введите значение x : ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y : ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}