//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[]arr= new int [size];
    Random rnd = new Random();

    for (int i=0; i<size; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    //Console.WriteLine ("[");
    for (int i=0; i<arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write ($"{arr[i]}, ");
        else Console.Write ($"{arr[i]}");
    }
    //Console.WriteLine ("]");
}
int Max (int[] arr)
{
    int max=0;
    for (int i=0; i<arr.Length; i++)
    {
        if (max<=arr[i]) max=arr[i];
    }
    return max;
}
int Min (int[] arr)
{
    int min=1000;
    for (int i=0; i<arr.Length; i++)
    {
        if (min>=arr[i]) min=arr[i];
    }
    return min;
}

int[] array = CreateArrayRndInt(4,10,99);
PrintArray(array);
Console.Write("-> [");
PrintArray(array);
Console.WriteLine("]");
int difference = Max(array)-Min(array);
Console.WriteLine($"Разница между максимальным и минимальным значением: {difference}");