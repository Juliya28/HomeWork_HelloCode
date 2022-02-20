// 42.	Определить сколько чисел больше 0 введено с клавиатуры.

Console.WriteLine("Введите числа через пробел: ");
string num = Console.ReadLine();
string[] array = num.Split(' ');

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (int.Parse(array[i]) > 0) result++;
}
Console.WriteLine("Количество чисел больше 0: " + result);
