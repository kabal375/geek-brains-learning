// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int choice = 0;

while (choice != 4)
{
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1)
    {
        CheckStringForPalyndrom();
    }
    else if (choice == 2)
    {
        //
    }
    else if (choice == 3)
    {
        //
    }
}

void showMenu()
{
    Console.Clear();

    Console.WriteLine("1 - Проверка строки на палиндром");
    Console.WriteLine("2 - Третья цифра числа (если есть)");
    Console.WriteLine("3 - День недели");
    Console.WriteLine("4 - Выход");

}

Boolean IsPalyndrom(string phrase, int shift = 0)
{
    Boolean result = true;
    if (phrase[0 + shift] == phrase[phrase.Length - (1 + shift)]) 
    {
        if (shift == phrase.Length / 2) result = true;
        else 
    {
      //  Console.WriteLine($"{shift} - {phrase[0 + shift]} - {phrase[phrase.Length - (1 + shift)]}");
        shift++;
        result = IsPalyndrom(phrase, shift);
    }

    } else result = false;

    return result;

}

void CheckStringForPalyndrom()
{
    Console.WriteLine("Введите строку (число):");
    string s = Console.ReadLine();

    if (IsPalyndrom(s)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
}