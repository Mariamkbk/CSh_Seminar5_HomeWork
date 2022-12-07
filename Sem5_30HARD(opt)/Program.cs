// Задача 30: - HARD необязательная Напишите программу,
// которая на вход получает размерность массива.
// Далее заполняет его случайными уникальными числами и выводит на экран.
// Далее производим сортировку массива от большего к меньшему и выводим на экран.
// Далее придумываем алгоритм перемешивания списка на основе случайности ,
// применяем этот алгоритм и выводим на экран результат.
// Встроенные методы работы со списками использовать нельзя.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    int i = 0;
    int j = 1;
    int jSave = 0;
    arr[i] = new Random().Next(1, 12);
    while (j < size)
    {
        arr[j] = new Random().Next(1, 12);
        jSave = arr[j];
        for (i = 0; i < j;)
        {
            while (arr[i] == arr[j])
            {
                arr[j] = new Random().Next(1, 12);
            }
            if (jSave != arr[j])
            {
                i = 0;
                jSave = arr[j];
            }
            else
                i++;
        }
        j++;
    }
    return arr;
}

void PrintArray(int[] Arr)
{
    foreach (int el in Arr)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr)
{
    int i = 0;
    int buffer = 0;
    int countIn = 0;
    while (countIn < arr.Length)
    {
        int max = arr[countIn];
        for (i = countIn; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                buffer = arr[countIn];
                arr[countIn] = max;
                arr[i] = buffer;
            }
        }
        countIn++;

    }
    return arr;
}
int[] MixNums(int[] array)
{
    int buffer = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, (array.Length - 1));
        buffer = array[i];
        array[i] = array[j];
        array[j] = buffer;
    }
    return array;
}
try
{
    Console.WriteLine("Введите  размерность массива");
    int len = Convert.ToInt32(Console.ReadLine());
    int[] Arr = FillArray(len);
    PrintArray(Arr);
    SortArray(Arr);
    PrintArray(Arr);
    MixNums(Arr);
    PrintArray(Arr);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}