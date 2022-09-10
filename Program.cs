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
string[] arr2 = new string[Length2];
int j = 0; 
for(int i = 0; i < Length1; i++)
{
    if(arr1[i].Length <= 3)
    {
        
        arr2[j] = arr1[i];
        j++;
        
    }
}
System.Console.WriteLine("Выражения состоящие из трёх или менее символов: ");
for(int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + " ");
}