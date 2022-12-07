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
void PrintArr(double[] arr, int[] array)
{
    Console.WriteLine($"Максимальный элемент данного массива: {FindMax(array)}");
    Console.WriteLine($"Индекс максимального элемента данного массива: {FindMaxIndex(array, FindMax(array))}");
    Console.WriteLine($"Минимальный элемент данного массива: {FindMin(array)}");
    Console.WriteLine($"Индекс минимального элемента данного массива: {FindMinIndex(array, FindMin(array))}");
    Console.WriteLine($"Среднее арифметическое всех элементов данного массива равно {ArithmeticMean(array)}");
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
int[] ArrangeArray(int[] arr)
{
    int i = 0;
    int save = 0;
    int count = 0;
    while (count < arr.Length)
    {
        int max = arr[count];
        for (i = count; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                save = arr[count];
                arr[count] = max;
                arr[i] = save;
            }
        }
        count++;

    }
    return arr;
}
double Mediana(int[] arr)
{
    ArrangeArray(arr);
    double med = 0;
    if (arr.Length % 2 == 0)
    {
        int i = arr.Length / 2;
        int j = arr.Length / 2 - 1;
        med = Convert.ToDouble((arr[i] + arr[j])) / 2;
    }
    else med = arr[arr.Length / 2];
    return med;
}

try
{
    Console.WriteLine("Введите  размерность массива от 1 до 20");
    int len = Convert.ToInt32(Console.ReadLine());
    int[] Arr = FillArray(len);
    Console.Write("Массив Arr: ");
    PrintArray(Arr);
    double[] NewArr = { FindMax(Arr), FindMaxIndex(Arr, FindMax(Arr)), FindMin(Arr), FindMinIndex(Arr, FindMin(Arr)), ArithmeticMean(Arr) };
    PrintArr(NewArr, Arr);
    Console.WriteLine($"Медианное значение массива Arr равно: {Mediana(Arr)}");
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}

