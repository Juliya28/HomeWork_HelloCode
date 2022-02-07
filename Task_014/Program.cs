// 14.	Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int number = num / 100 % 10;

if (number > 0)
{
    Console.WriteLine(number);
}
else 
{
    Console.WriteLine("Третья цифра отсутствует");
}
