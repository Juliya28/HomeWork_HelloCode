// Даны два числа. Показать большее и меньшее число.

int a1 = 8;
int a2 = 10;
if (a1 > a2)
{
    Console.WriteLine("Большее: " + a1);
    Console.WriteLine("Меньшее: " + a2);
}
else if (a1 < a2)
{
    Console.WriteLine("Большее: " + a2);
    Console.WriteLine("Меньшее: " + a1);
}
else
{
    Console.WriteLine("Числа равны");
}

