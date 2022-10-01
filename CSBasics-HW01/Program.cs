
int choice = 0;

while (choice != 5) {
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1) {
        maxOfTwo();
    } else if (choice == 2) {
        maxOfThree();
    } else if (choice == 3) {
        isNumberEven();
    } else if (choice == 4) {
        showEvenNumbers();
    }
}

void showMenu() {
    Console.Clear();

    Console.WriteLine("1 - Найти максимум из двух чисел");
    Console.WriteLine("2 - Найти максимум из трёх чисел");
    Console.WriteLine("3 - Является ли число чётным");
    Console.WriteLine("4 - Чётные числа от 1 до N");
    Console.WriteLine("5 - Выход");
}


void maxOfTwo() {
    //  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.WriteLine("Введите первое число:");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int n2 = Convert.ToInt32(Console.ReadLine());
    if (n1 > n2) {
        Console.WriteLine("max = " + n1);
    } else if (n1 < n2) {
        Console.WriteLine("max = " + n2);
    } else Console.WriteLine("Числа равны");
    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
}

void maxOfThree() {
    // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.WriteLine("Введите первое число:");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число:");
    int n3 = Convert.ToInt32(Console.ReadLine());

    int max = n1;

    if (n2 > max) max = n2;
    if (n3 > max) max = n3;

    Console.WriteLine("max = " + max);

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
}

void isNumberEven() {
    // Напишите программу, которая на вход принимает число и выдаёт, 
    // является ли число чётным (делится ли оно на два без остатка).
    Console.WriteLine("Введите число:");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n % 2 == 0) Console.WriteLine("да");
    else Console.WriteLine("нет");

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
}

void showEvenNumbers(){
    //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    Console.WriteLine("Введите число, большее 1:");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 1) Console.WriteLine("Число меньше 1");
    else {
        int evenNumber = 2;
        while (evenNumber <= n-2) {
            Console.Write(evenNumber + ", ");
            evenNumber += 2;
        }
        Console.WriteLine(evenNumber);
    }
    
    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();

}