// Даны два числа. Показать большее и меньшее число.

int a1 = 12;
int a2 = 14;
int max = a1;
if (a2 < max)
{
    Console.WriteLine("Большее: " + max);
    Console.WriteLine("Меньшее: " + a2);
}
else if (max < a2)
{
    Console.WriteLine("Большее: " + a2);
    Console.WriteLine("Меньшее: " + max);
}
else
{
    Console.WriteLine("Числа равны");
}

