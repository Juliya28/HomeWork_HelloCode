// 20.	Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите цифру от 1 до 4 : ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();

int x = 0;
int y = 0;

if (num == 1)
{
    Console.WriteLine("Диапазон I четверти: {x > 0 и y > 0}");
}
else if (num == 2)
{
    Console.WriteLine("Диапазон II четверти: {x < 0 и y > 0}");
}
else if (num == 3)
{
    Console.WriteLine("Диапазон III четверти: {x < 0 и y < 0}");
}
else if (num == 4)
{
    Console.WriteLine("Диапазон IV четверти: {x > 0 и y < 0}");
}
