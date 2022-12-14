int choice = 0;

while (choice != 6)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {
        // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
        // элементы каждой строки двумерного массива.
        Task1();
    }
    else if (choice == 2)
    {
        // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
        // которая будет находить строку с наименьшей суммой элементов.
        Task2();
    }

    else if (choice == 3)
    {
        // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        Task3();
    }
    else if (choice == 4)
    {
        // Задача 60...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        Task4();
    }
    else if (choice == 5)
    {
        // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        Task5();
    }

}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Упорядочить по убыванию строки матрицы");
    Console.WriteLine("2 - Найти строку с минимальной суммой элементов");
    Console.WriteLine("3 - Найти произведение двух матриц");
    Console.WriteLine("4 - Трёхмерный массив неповторяющихся чисел");
    Console.WriteLine("5 - Заполнить матрицу спирально");
    Console.WriteLine("6 - Выход");

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

void ShowInt2DimArray(int[,] arr)
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


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
void Task1()

{
    int[,] arr1 = CreateRandomInt2DimArray(5, 5);

    Console.WriteLine("Исходный массив:");
    ShowInt2DimArray(arr1);

    SortRows(arr1);

    Console.WriteLine();
    Console.WriteLine("После сортировки:");
    ShowInt2DimArray(arr1);

    ShowPressAnyKey();

}

void SortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
            for (int j = 0; j < matrix.GetLength(1) - k - 1; j++)
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    // swap temp and arr[i]
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
    }

}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
void Task2()
{
    int[,] arr2 = CreateRandomInt2DimArray(5, 5);

    Console.WriteLine("Исходный массив:");
    ShowInt2DimArray(arr2);

    Console.WriteLine($"Строка с минимальной суммой элементов: {FindRowWithMinSum(arr2)}");

    ShowPressAnyKey();

}

int FindRowWithMinSum(int[,] matrix)
{
    int rowSumMin = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        rowSumMin += matrix[0, k];
    }

    int rowSum = 0;
    int rowNumber = 0;

    if (matrix.GetLength(0) > 1)
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rowSum += matrix[i, j];
            }

            if (rowSum < rowSumMin)
            {
                rowSumMin = rowSum;
                rowNumber = i;
            }

            // Console.WriteLine($"Сумма элементов строки {i+1}: {rowSum}");
            rowSum = 0;

        }

    return rowNumber + 1;
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Task3()
{
    int[,] firstMatrix = CreateRandomInt2DimArray(3, 3);
    Console.WriteLine("Исходный массив 1:");
    ShowInt2DimArray(firstMatrix);
    Console.WriteLine();
    //Thread.Sleep(100);
    int[,] secondMatrix = CreateRandomInt2DimArray(3, 3);
    Console.WriteLine("Исходный массив 2:");
    ShowInt2DimArray(secondMatrix);
    Console.WriteLine();

    int[,] resultMatrix = MultiplyMatrices(firstMatrix, secondMatrix);

    ShowInt2DimArray(resultMatrix);

    ShowPressAnyKey();
}


int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(0)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return resultMatrix;
}

// Задача 60...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void Task4()
{
    int n = 3;
    int m = 3;
    int l = 3;

    int v = 0;

    int[,,] arr = new int[n, m, l];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            for (int k = 0; k < l; k++)
            {
                v++;
                arr[i, j, k] = v;

                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        Console.WriteLine();
    }
    ShowPressAnyKey();
    //return arr;
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void Task5()
{
    int n = 4;

    int[,] arr = new int[n, n];

    int v = 0;
    int count = n;
    int value = -n;
    int sum = -1;

    do
    {
        value = -1 * value / n;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            arr[sum / n, sum % n] = ++v;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            arr[sum / n, sum % n] = ++v;
        }
    } while (count > 0);


    ShowInt2DimArray(arr);

    ShowPressAnyKey();

}