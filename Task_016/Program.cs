// 16.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.WriteLine("Введите число от 1 до 7 (обозначающее день недели) : ");
int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}