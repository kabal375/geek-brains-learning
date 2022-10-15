int choice = 0;

while (choice != 6)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {
        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        // Напишите программу, которая покажет количество чётных чисел в массиве.

        int[] array1 = CreateRandomIntArray(max: 1001, min: 100);
        Console.WriteLine($"[{string.Join(", ", array1)}]");

        Console.WriteLine($"{ArrSumEven(array1)}");

        ShowPressAnyKey();
    }
    else if (choice == 2)
    {
        // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        // Найдите сумму элементов, стоящих на нечётных позициях.

        int[] array2 = CreateRandomIntArray();
        Console.WriteLine($"[{string.Join(", ", array2)}]");

        Console.WriteLine($"{ArrEvenCount(array2)}");

        ShowPressAnyKey();

    }
    else if (choice == 3)
    {
        // Задача 38: Задайте массив вещественных чисел. 
        // Найдите разницу между максимальным и минимальным элементов массива.

        double[] array3 = CreateRandomDoubleArray();
        Console.WriteLine($"[{string.Join(", ", array3)}]");

        Console.WriteLine($"{FindMaxMinDifference(array3)}");

        ShowPressAnyKey();


    }
    else if (choice == 4)
    {
        // Задана последовательность натуральных чисел, завершающаяся числом 0. 
        // Требуется определить значение второго по величине элемента в этой последовательности, 
        // то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
        int arrSize = new Random().Next(3, 101);
        int[] array4 = CreateRandomIntArray(n: arrSize, min: -100, max: 100);
        array4[array4.Length - 1] = 0;

        Console.WriteLine($"[{string.Join(", ", array4)}]");

        Console.WriteLine($"{FindSecondMax(array4)}");

        ShowPressAnyKey();

    }

    else if (choice == 5)
    {
        // Дана последовательность из N целых чисел и число K. 
        // Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
        // на |K| элементов вправо, если K – положительное и влево, если отрицательное.

        int[] array5 = CreateRandomIntArray(min: 0);

        Console.WriteLine($"[{string.Join(", ", array5)}]");

        Console.Write("Введите число: ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"[{string.Join(", ", ShiftArray(array5, k))}]");

        ShowPressAnyKey();

    }

}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Количество чётных чисел в массиве");
    Console.WriteLine("2 - Сумма элементов на нечётных позициях массива");
    Console.WriteLine("3 - Разница между Max и Min массива");
    Console.WriteLine("4 - Второй максимум массива");
    Console.WriteLine("5 - Суперсдвиг");
    Console.WriteLine("6 - Выход");

}

void ShowPressAnyKey()
{
    Console.WriteLine("Нажмите любую клавишу...");
    Console.ReadKey();
}

int[] CreateRandomIntArray(int n = 0, int min = -10, int max = 10)
{
    if (n == 0) n = new Random().Next(5, 11);

    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max + 1);

    return arr;
}

double[] CreateRandomDoubleArray(int n = 0, int min = -10000, int max = 10000)
{
    if (n == 0) n = new Random().Next(5, 11);

    double[] arr = new double[n];

    for (int i = 0; i < arr.Length; i++) arr[i] = Math.Round(new Random().Next(min, max + 1) * .001, 3);

    return arr;
}


int ArrSumEven(int[] array)
{
    int sumEven = 0;

    for (int i = 0; i < array.Length; i += 2) sumEven += array[i];

    return sumEven;

}

int ArrEvenCount(int[] array)
{
    int evenCount = 0;

    foreach (int n in array)
    {
        if (n % 2 == 0) evenCount += n;
    }

    return evenCount;
}

double FindMaxMinDifference(double[] array)
{
    //double difference = 0;
    double max = array[0], min = array[0];

    foreach (double d in array)
    {
        if (d > max) max = d;
        if (d < min) min = d;
    }

    return max - min;
}

int FindSecondMax(int[] array)
{
    int firstMax = array[0], secondMax = array[0];

    foreach (int n in array)
    {
        if (n > firstMax)
        {
            secondMax = firstMax;
            firstMax = n;
        }
        else if (n > secondMax) secondMax = n;
    }

    return secondMax;
}

int[] ShiftArray(int[] array, int k)
{
    bool shiftRight = (k >= 0);

    int l = array.Length;

    k = Math.Abs(k);
    if (k > l) k = k % l;

    int[] shiftedArr = new int[l];


    for (int i = 0; i < l; i++)
    {
        if (shiftRight)
        {
            if (i + k > l - 1) shiftedArr[i + k - l] = array[i];
            else shiftedArr[i + k] = array[i];
        }
        else
        {
            if (i - k < 0) shiftedArr[i - k + l] = array[i];
            else shiftedArr[i - k] = array[i];
        }
    }

    return shiftedArr;
}