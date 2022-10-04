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
        //
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

