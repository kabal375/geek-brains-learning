int choice = 0;

while (choice != 4)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {
        ShowSecondDigitOfThree();
    }
    else if (choice == 2)
    {
        ShowThirdDigit();
    }
    else if (choice == 3)
    {
        IsItWeekEnd();
    }
}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Вторая цифра трёхзначного числа");
    Console.WriteLine("2 - Третья цифра числа (если есть)");
    Console.WriteLine("3 - День недели");
    Console.WriteLine("4 - Выход");
}

void ShowSecondDigitOfThree()
{
    //  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.WriteLine("Введите трёхзначное число:");
    string n = Console.ReadLine();
    if (n.Length != 3) Console.WriteLine("Число не трёхзначное");
    else
    {
        Console.WriteLine(n[1]);
    }

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();

}

void ShowThirdDigit()
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
{
    string n = Convert.ToString(new Random().Next(1, 100000));
    Console.WriteLine($"Заданное число: {n}");

    if (n.Length < 3) Console.WriteLine("Третьей цифры нет");
    else
    {
        Console.WriteLine(n[2]);
    }

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();

}

void IsItWeekEnd()
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
{
    Console.WriteLine("Введите номер дня недели:");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n > 0 && n < 6) Console.WriteLine("Нет");
    else if (n > 5 && n < 8) Console.WriteLine("Да");
    else Console.WriteLine("Не день недели!");

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();

}

