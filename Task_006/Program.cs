// 6.	Выяснить является ли число чётным.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);
if (num % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}