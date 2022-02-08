// 21.	Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int a1 = number % 10;
int a2 = number / 10 % 10;
int a3 = number / 100 % 10;
int a4 = number / 1000 % 10;
int a5 = number / 10000;

if (a1 == a5 && a2 == a4)
{
    Console.WriteLine("Является полиндромом");
}
else
{
    Console.WriteLine("Не является полиндромом");
}
