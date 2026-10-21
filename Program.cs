// PrintHeader("Задание 1");
// Console.WriteLine();
// PrintHeader("method printheader");

// Console.WriteLine("задание 2.1");
// int max1 = Max(4, 9);
// Console.WriteLine($"больше из 4 и 9: {max1}");
// int max2 = Max(36, 13);
// Console.WriteLine($"больше из 36 и 13: {max2}");

// Console.WriteLine("задание 2.2");
// Console.WriteLine($"Число 4 чётное? {IsEven(4)}");
// Console.WriteLine($"Число 7 чётное? {IsEven(7)}");
// Console.WriteLine($"Число 0 чётное? {IsEven(0)}");

// Console.WriteLine("задание 3");
// int[] array = {63, 45, 274, 67, 15, 175};
// double avg = Average(array);
// Console.WriteLine($"Среднее: {avg}");
// int count = CountGreater(array, 100);
// Console.WriteLine($"CountGreater(arr, 100): {count}");

// Console.WriteLine("задание 4");
// double c1 = ToFarenheit(0);
// Console.WriteLine($"0 градусов цельсия в фаренгейтах = {c1}");
// double c2 = ToFarenheit(100);
// Console.WriteLine($"100 градусов цельсия в фаренгейтах = {c2}");
// double c3 = ToFarenheit(37);
// Console.WriteLine($"37 градусов цельсия в фаренгейтах = {c3}");

// Console.WriteLine("задание 5");
// Console.WriteLine($"Factorial(5) = {Factorial(5)}"); 

// Console.WriteLine("Простые числа от 2 до 50:");
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i))
//     {
//         Console.Write(i + " ");
//     }
// }
// Console.WriteLine();

// Console.WriteLine("задание 6");
// int number1 = ReadPositive("Введите первое положительное число: ");
// int number2 = ReadPositive("Введите второе положительное число: ");
// int totalSum = number1 + number2;
// Console.WriteLine($"Сумма введённых чисел: {totalSum}");


// static void PrintLine()
// {
//     Console.WriteLine("<3 <3 <3 <3 <3 <3 <3");
// }

// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// }
Console.WriteLine("Калькулятор");
int choice;

do
{
    Console.WriteLine("1 — сумма двух чисел");
    Console.WriteLine("2 — большее из двух чисел");
    Console.WriteLine("3 — факториал");
    Console.WriteLine("0 — выход");
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Нет такого пункта.");
        continue;
    }
    switch (choice)
    {
        case 1:
            Console.WriteLine("\n[Выбрано: сумма двух чисел]");
            int s1 = ReadPositive("Введите первое число: ");
            int s2 = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Результат (сумма): {Sum(s1, s2)}");
            break;

        case 2:
            Console.WriteLine("\n[Выбрано: большее из двух чисел]");
            int m1 = ReadPositive("Введите первое число: ");
            int m2 = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Результат (большее): {Max(m1, m2)}");
            break;

        case 3:
            Console.WriteLine("\n[Выбрано: факториал]");
            int n = ReadPositive("Введите число для расчета факториала: ");
            Console.WriteLine($"Результат ({n}!): {Factorial(n)}");
            break;

        case 0:
            Console.WriteLine("\nВыход из программы. До свидания!");
            break;

        default:
            Console.WriteLine("Нет такого пункта.");
            break;
    }

} while (choice != 0);


static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }

// static double Average(int[] arr)
// {
//     if (arr.Length == 0) return 0;

//     double sum = 0;
//     foreach (int x in arr)
//     {
//         sum += x;
//     }
//     return sum / arr.Length;
// }

// static int CountGreater(int[] arr, int limit)
// {
//     int count = 0;
//     foreach (int x in arr)
//     {
//         if (x > limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// static double ToFarenheit(int c)
// {
//     return c * 9 / 5 + 32;
// }

static long Factorial(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
// static bool IsPrime(int n)
// {
//     if (n < 2) return false;
//     for (int i = 2; i * i <= n; i++)
//     {
//         if (n % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }

static int ReadPositive(string message)
{
    int number;
    do
    {
        Console.Write(message);
        string input = Console.ReadLine();

        if (int.TryParse(input, out number))
        {
            if (number > 0)
            {
                break;
            }
        }
        Console.WriteLine("Ошибка! Нужно ввести ПОЛОЖИТЕЛЬНОЕ число (больше 0). Попробуйте снова.");
    }
    while (true);
    return number;
}
static int Sum(int a, int b)
{
    return a + b;
}