// 27.	Определить количество цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int result = 0;
while (num > 0)
{
    num = num / 10;
    result++;
}
Console.WriteLine(result);