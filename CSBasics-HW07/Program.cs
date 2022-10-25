

int choice = 0;

while (choice != 4)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {  // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

        
        ShowDouble2DimArray(CreateRandomDouble2DimArray());
        ShowPressAnyKey();

    }
    else if (choice == 2)
    {
        // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
        // и возвращает значение этого элемента или же указание, что такого элемента нет.
        
        double[,] arr1 = CreateRandomDouble2DimArray();
        ShowDouble2DimArray(arr1);

        Console.Write("Введите номер строки: ");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца: ");
        int j = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine(arr1[i-1, j-1]);
        }
        catch (System.IndexOutOfRangeException)
        {
            Console.WriteLine("Позиции указаны некорректно!");
           // throw;
        }
        ShowPressAnyKey();
    }

    else if (choice == 3)
    {
        // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


    }

}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Двумерный массив вещестенных чисел");
    Console.WriteLine("2 - Возвращаем элемент по координатам");
    Console.WriteLine("3 - Среднее арифметическое столбцов массива");
    Console.WriteLine("4 - Выход");

}

void ShowPressAnyKey()
{
    Console.WriteLine("Нажмите любую клавишу...");
    Console.ReadKey();
}


int[,] CreateRandomInt2DimArray(int n = 0, int m = 0, int min = -10, int max = 10)
{
    if (n == 0) n = new Random().Next(3, 6);
    if (m == 0) m = new Random().Next(3, 6);

    int[,] arr = new int[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            arr[i, j] = new Random().Next(min, max + 1);

    return arr;
}

double[,] CreateRandomDouble2DimArray(int n = 0, int m = 0, int min = -10000, int max = 10000)
{
    if (n == 0) n = new Random().Next(3, 6);
    if (m == 0) m = new Random().Next(3, 6);

    double[,] arr = new double[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            arr[i, j] = Math.Round(new Random().Next(min, max + 1) * .001, 3);

    return arr;
}

void ShowInt2DimArray(int[,] arr)
{
    string addSpace = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 0) addSpace = " "; 
            else addSpace = "";
            Console.Write(addSpace + arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowDouble2DimArray(double[,] arr)
{
    string addSpace = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 0) addSpace = ""; 
            else addSpace = " ";
            Console.Write(addSpace + arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

