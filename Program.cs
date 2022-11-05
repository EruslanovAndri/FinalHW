Console.Clear();
Console.Write("Введите кол-во элементов: ");
string[] arrayOne = new string[20];
int n = int.Parse(Console.ReadLine());




void FillAndPrintStringArray(int n)
{
    for (int i = 0; i < n; i++)
    {
        arrayOne[i] = Console.ReadLine();
    }
    for (int i = 0; i < n; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < n - 1) Console.Write(arrayOne[i] + ",");
        else Console.WriteLine(arrayOne[i] + "]");
    }
}


FillAndPrintStringArray(n);











