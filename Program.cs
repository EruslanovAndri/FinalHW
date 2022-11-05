Console.Clear();
int italon = 3;
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Напишите {n} слов/слова, которые вы желаете увидеть на экране: ");
string[] arrayOne = new string[n];


void FillArray(string[]arr)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

void FillArrayRandomly(string[] arr)
{
    Random rnd = new Random();
    string simbols = "1234567890-=!@#$%^&*()_+qwertyuiop[]asdfghjkl;'zxcvbnm,./QWERTYUIOP[]ASDFGHJKL;'ZXCVBNM,./";
    for (int i = 0; i < arr.Length; i++)
    {
        int randomElementSize = rnd.Next(1,10);
        for (int j = 0; j < randomElementSize; j++)
        {
            arr[i] += simbols[rnd.Next(0,simbols.Length)];
        }
    }
}

void PrintArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[ ");
        if (i < arr.Length - 1) Console.Write(arr[i] + " , ");
        else Console.WriteLine(arr[i] + " ]");
    }
}

int GetSizeSecondArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= italon)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[GetSizeSecondArray(arrayOne)];
    for (int i = 0, j = 0;  i < arr.Length; i++)
    {
        if(arr[i].Length <= italon)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;

}

// FillArray(arrayOne);
FillArrayRandomly(arrayOne);
Console.Clear();
Console.Write("Изночальный массив: => ");
PrintArray(arrayOne);
if(GetSizeSecondArray(arrayOne) == 0)
{
    Console.WriteLine("В данном массиве все элементы имеют более трёх символов.");
}
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    Console.Write("Результирующий массив: =>");
    PrintArray(arrayTwo);
}











