// 74.	В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

string text = "аисв";
int num = 3;

string[] Alfavit(string ABS, int n)
{
    if (n == 0) return new string [] {""};
    string[] mass = Alfavit(ABS, n - 1);
    string[] result = new string[ABS.Length * mass.Length];
    int k = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        for (int j = 0; j < ABS.Length; j++)
        {
            result[k] = mass[i] + ABS[j];
            k++;
        }
    }
    return result;
}

string[] array = Alfavit(text, num);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}