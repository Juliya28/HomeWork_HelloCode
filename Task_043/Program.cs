// 43.	Написать программу преобразования десятичного числа в двоичное.

Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();

string result = "";
while (a != 0)
{
    result = (a % 2).ToString() + result;
    a = a / 2;
    
}
Console.Write(result);
Console.WriteLine();
