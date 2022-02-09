// 14.	Найти третью цифру числа или сообщить, что её нет.

int GetRandomNumber()
{
    int randomNumber = new Random().Next(0, 10000);
    return randomNumber;
}
int randomValue = GetRandomNumber();
Console.WriteLine($"Дано число: {randomValue}");
while (randomValue > 999)
{
    randomValue = randomValue / 10;
}
   Console.WriteLine($"Необходимый диапазон {randomValue}");
   if (randomValue >= 100)
   {
       Console.WriteLine($"Третье число {randomValue % 10}");
   } 
   else
   {
       Console.WriteLine($"Третьего числа нет");
   }