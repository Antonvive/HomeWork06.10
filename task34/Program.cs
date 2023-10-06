//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
int Parity (int[] arr)
{
    int k=0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i]%2==0) k=k+1;
    }
    return k;
}
int[] array = CreateArrayRndInt(12,100,999);
PrintArray(array);
Console.Write("-> [");
PrintArray(array);
Console.WriteLine("]");

Console.WriteLine($"Количество четных чисел: {Parity (array)}");