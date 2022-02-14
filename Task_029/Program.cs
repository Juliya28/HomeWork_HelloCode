// 29.	Написать программу вычисления произведения чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Числа от 1 до N: " + "\t");
Console.WriteLine();

int num = 1;
for (int i = 1; i <= num1; i++)
{
    num = num * i;
}
Console.WriteLine();
Console.WriteLine("Произведение чисел от 1 до N: " + num);
Console.WriteLine();
