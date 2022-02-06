// 11.	Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

Console.WriteLine("Дано число из отрезка [10, 99]");
int num = new Random().Next(10, 99);
Console.WriteLine(num);

int a = num % 10;
int b = num / 10;

if (a > b)
{
    Console.WriteLine("Наибольшая цифра: " + a);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + b);
}