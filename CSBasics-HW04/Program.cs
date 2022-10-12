int choice = 0;

while (choice != 4)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {
        Task1();
    }
    else if (choice == 2)
    {
        Task2();
    }
    else if (choice == 3)
    {
        Task3();
    }
}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - А в степень В");
    Console.WriteLine("2 - Сумма цифр в числе");
    Console.WriteLine("3 - Вывод массива");
    Console.WriteLine("4 - Выход");

}

void Task1()
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

{
    Console.Write("Введите число (любое): ");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите степень (целое число): ");
    int power = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(CustomPow(number, power));

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
}

double CustomPow(double number, int power)
{
    double result = number;

    if (power > 1)
    {
        for (int i = 2; i <= power; i++)
        {
            result *= number;
        }
    }

    return result;
}

void Task2()
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(GetSumOfDigits(number));

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();

}

int GetSumOfDigits(int number)
{
    int n = Math.Abs(number);
    int sum = 0;

    while (n > 0) 
    {
        sum += n % 10;
        n = n / 10;
    }

    return sum;
}

void Task3()
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
{
    Console.Write("Введите несколько символов через запятую: ");

    string[] elements = Console.ReadLine().Split(',');

    Console.WriteLine($"[{string.Join(", ", elements)}]");

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
}