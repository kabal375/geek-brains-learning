int choice = 0;

while (choice != 5)
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
//        OptionalTask();
    }

}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Количество чётных чисел в массиве");
    Console.WriteLine("2 - Сумма элементов на нечётных позициях массива");
    Console.WriteLine("3 - Разница между Max и Min массива");
    Console.WriteLine("4 - ...");
    Console.WriteLine("5 - Выход");

}

void ShowPressAnyKey()
{
    Console.WriteLine("Нажмите любую клавишу...");
    Console.ReadKey();
}

int[] CreateRandomIntArray(int n = 0, int min = -10, int max = 10)
{
    if (n == 0) n = new Random().Next(5,11);

    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max + 1);

    return arr;
}

double[] CreateRandomDoubleArray(int n = 0, int min = -10000, int max = 10000)
{
    if (n == 0) n = new Random().Next(5,11);

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
    double max = 0, min = 0;

    foreach (double d in array)
    {
        if (d > max) max = d;
        if (d < min) min = d;
    }

    return max - min;
}
