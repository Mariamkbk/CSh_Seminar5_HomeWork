// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

int[] FillArray(int size)
{
    int[] SomeArr = new int[size];
    for (int i = 0; i < size; i++) SomeArr[i] = new Random().Next(-10, 21);
    return SomeArr;
}

void PrintArray(int[] arr)
{
    foreach (int el in arr) Console.Write($"{el} ");
    Console.WriteLine();
}

int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

int FindMaxIndex(int[] arr, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == max) int MaxIndex = i;
    }
    return MaxIndex;
}
int FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

int FindMinIndex(int[] arr, int min)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == min) int MinIndex = i;
    }
    return MinIndex;
}

int ArithmeticMean(int[] arr)
{
    int arithmetic = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arithmetic += arr[i];
    }
    arithmetic /= arr.Length;
}
try
{
    int len = Convert.ToInt32(Console.ReadLine());
    int[] Arr = FillArray(len);
    PrintArray(Arr);
    int[] array = new int[max, maxind, min, minind, arifm];
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}

