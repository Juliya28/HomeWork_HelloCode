// 28.	Подсчитать сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int summ = 0;
while (num > 0)
{
    summ += num % 10;
    num = num / 10;
}
Console.WriteLine("Сумма чисел: " + summ);
