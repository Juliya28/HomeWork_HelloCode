// 14.	Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int number = num % 10;

if (num < 100)
{
    Console.WriteLine("Третья цифра отсутствует");
}
else 
{
    Console.WriteLine(number);
}
