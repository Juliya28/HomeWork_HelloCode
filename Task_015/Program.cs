// 15.	Дано число. Проверить кратно ли оно 7 и 23.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine(num + " Кратно");
}
else
{
    Console.WriteLine(num + " Не кратно");
}
