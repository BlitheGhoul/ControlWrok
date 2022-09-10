Console.Write("Какое количество выражений вы планируете? Введите число: ");
int Length1 = int.Parse(Console.ReadLine());
string[] arr1 = new string [Length1];
int Length2 = 0;
for(int i = 0; i < Length1; i++)
{
    Console.Write("Введите выражение: ");
    arr1[i] = Console.ReadLine();
    if (arr1[i].Length <= 3) Length2++;
}