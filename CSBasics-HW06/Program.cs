
int choice = 0;

while (choice != 3)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {  // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        Console.WriteLine("Введите число:");
        int m = Convert.ToInt32(Console.ReadLine());
        Task1(m);
    }
    else if (choice == 2)
    {
        // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
        // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

        Task2();
    }

}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Считаем числа больше 0");
    Console.WriteLine("2 - Изем точку пересечения двух прямых");
    Console.WriteLine("3 - Выход");

}

void ShowPressAnyKey()
{
    Console.WriteLine("Нажмите любую клавишу...");
    Console.ReadKey();
}

void Task1(int m)
{
    int positiveCounter = 0;
    Console.WriteLine($"Введите {m} целых чисел:");

    for (int i = 0; i < m; i++)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0) positiveCounter++;
    }

    Console.WriteLine($" Вы ввели {positiveCounter} чисел больше 0");

    ShowPressAnyKey();

}

void Task2()
{
    Console.Write("Введите k1:");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1:");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2:");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2:");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2) Console.WriteLine("Данные прямые параллельны (а параллельные прямые не пересекаются)");
    else
    {
        double x = FindX(k1, b1, k2, b2);
        double y = FindY(k1, b1, x);
        Console.WriteLine($"Прямые пересекутся в точке X={x}, Y={y}");
    }

    ShowPressAnyKey();
}

double FindX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);

}

double FindY(double k, double b, double x)
{
    return k * x + b;

}