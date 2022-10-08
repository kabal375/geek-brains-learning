
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
        // Console.WriteLine(Find3Ddistance(3,6,8,2,1,-7));
        // Console.WriteLine(Find3Ddistance(7,-5,0,1,-1,9));
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

    Console.WriteLine("1 - Проверка строки на палиндром");
    Console.WriteLine("2 - Расстояние между точками в 3D");
    Console.WriteLine("3 - Список кубов чисел от 1 до N");
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

void Task1()
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

{
    Console.WriteLine("Введите строку (число):");
    string s = Console.ReadLine();

    if (IsPalyndrom(s)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
}


double Find3Ddistance(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Round(Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((bz - az),2)), 2);
}

 void Task2()
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 {
    Console.WriteLine("Введите координаты точки А:");
    double ax = Convert.ToDouble(Console.ReadLine());
    double ay = Convert.ToDouble(Console.ReadLine());
    double az = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B:");
    double bx = Convert.ToDouble(Console.ReadLine());
    double by = Convert.ToDouble(Console.ReadLine());
    double bz = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(Find3Ddistance(ax, ay, az, bx, by, bz));

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
 }

 void Task3()
 {
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.    
    
    Console.WriteLine("Введите число, большее 1:");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 1) Console.WriteLine("Число меньше 1");
    else {
        int cube = 1;
        for (cube = 1; cube < n; cube++) {
            Console.Write(Math.Pow(cube, 3) + ", ");
        }
        Console.WriteLine(Math.Pow(cube, 3));
    }
    
    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();

}