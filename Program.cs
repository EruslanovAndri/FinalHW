Console.Clear();
Console.WriteLine("Введите кол-во элементов: ");
string[] s = new string[10];
int n = int.Parse(Console.ReadLine());;




for (int i = 0; i < n; i++)
{
    s[i] = Console.ReadLine();
}
for (int i = 0; i < n; i++)
{
    Console.Write(s[i] + ",");
}


