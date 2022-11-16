int choice = 0;

while (choice != 3)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {
        // Задача 66: Задайте значения M и N. Напишите программу, 
        // которая найдёт сумму натуральных элементов в промежутке от M до N.
        Console.Write("Введите N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(SumBetweenTwoNumbers(n, m));

        ShowPressAnyKey();

    }
    else if (choice == 2)
    {
        // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
        // Даны два неотрицательных числа m и n.

        Console.Write("Введите m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(Ackermann(m, n));

        ShowPressAnyKey();
    }



}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Рекурсия: сумма натуральных чисел между N и M");
    Console.WriteLine("2 - Рекурсия: функция Аккермана");
    Console.WriteLine("3 - Выход");

}

void ShowPressAnyKey()
{
    Console.WriteLine("Нажмите любую клавишу...");
    Console.ReadKey();
}

int SumBetweenTwoNumbers(int n, int m)
{
    if (n > m)
    {
        int t = n;
        n = m;
        m = t;
    }
    if (n == m) return n;
    else return SumBetweenTwoNumbers(n + 1, m) + n;
}

int Ackermann(int m, int n)
{
    if (m <0 || n < 0) return -1; // -1 будем получать при некорректных вводных

    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
    
}