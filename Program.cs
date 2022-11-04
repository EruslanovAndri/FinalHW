Console.Clear();
Console.Write("Введите кол-во элементов: ");
string[] s = new string[20];
int n = int.Parse(Console.ReadLine()); ;


void PrintStringArray(int n)
{
    for (int i = 0; i < n; i++)
    {
        s[i] = Console.ReadLine();
    }
    for (int i = 0; i < n; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < n - 1) Console.Write(s[i] + ",");
        else Console.WriteLine(s[i] + "]");
    }

}

PrintStringArray(n);



