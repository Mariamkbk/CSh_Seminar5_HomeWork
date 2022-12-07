// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

int[] FillArray(int size)
{
    int[] SomeArr = new int[size];
    for (int i = 0; i < size; i++) SomeArr[i] = new Random().Next(1, 21);
    return SomeArr;
}

void PrintArray(int[] arr)
{
    foreach (int el in arr) Console.Write($"{el} ");
    Console.WriteLine();
}
void PrintArr(double[] arr,int[]array)
{
    Console.WriteLine($"Максимальный элемент массива равен {FindMax(array)}");
    Console.WriteLine($"Индекс максимального элемента массива равен {FindMaxIndex(array, FindMax(array))}");
    Console.WriteLine($"Минимальный элемент массива равен {FindMin(array)}");
    Console.WriteLine($"Индекс минимального элемента массива равен {FindMinIndex(array, FindMin(array))}");
    Console.WriteLine($"Среднее арифметическое всех элементов массива равно {ArithmeticMean(array)}");
    // foreach (double el in arr) Console.Write($"{el} ");
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
    int MaxIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == max) MaxIndex = i;
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
    int MinIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == min) MinIndex = i;
    }
    return MinIndex;
}

double ArithmeticMean(int[] arr)
{
    double arithmetic = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arithmetic += arr[i];
    }
    arithmetic /= arr.Length;
    return arithmetic;
}
try
{
    int len = 10;
    int[] Arr = FillArray(len);
    PrintArray(Arr);
    double[] NewArr = {FindMax(Arr), FindMaxIndex(Arr,FindMax(Arr)), FindMin(Arr), FindMinIndex(Arr,FindMin(Arr)), ArithmeticMean(Arr)};
    PrintArr(NewArr,Arr);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}

