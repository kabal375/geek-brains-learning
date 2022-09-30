Console.Clear();

Console.WriteLine("1 - Найти максимум из двух чисел");
Console.WriteLine("2 - Найти максимум из трёх чисел");
Console.WriteLine("3 - Является ли число чётным");
Console.WriteLine("4 - Чётные числа от 1 до N");
Console.WriteLine("5 - Выход");

int choice = 0;

while (choice != 5) {
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ok");
}