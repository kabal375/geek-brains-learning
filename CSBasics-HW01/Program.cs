
int choice = 0;

while (choice != 5) {
    showMenu();
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");

    if (choice == 1) {
        maxOfTwo();
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
    //
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