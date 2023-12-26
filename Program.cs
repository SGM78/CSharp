Console.Write("Введите свое имя: ");
var name = Console.ReadLine();       // вводим имя
Console.WriteLine($"Привет {name}");    // выводим имя на консоль

// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Решение в ветке Task_1

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// Решение в ветке Task_2

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Решение в  ветке Task_3

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// Решение в ветке Task_4

 {
        // Пример 1: Проверка кратности числа 7 и 23
        Console.WriteLine("\nПример 1: Проверка кратности числа 7 и 23");
        Console.WriteLine("Введите число для проверки:");

        if (int.TryParse(Console.ReadLine(), out int checkNumber))
        {
            if (IsMultipleOfSevenAndTwentyThree(checkNumber))
            {
                Console.WriteLine($"{checkNumber} кратно и 7, и 23.");
            }
            else
            {
                Console.WriteLine($"{checkNumber} не кратно одновременно 7 и 23.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }

        // Пример 2: Определение номера координатной четверти
        Console.WriteLine("\nПример 2: Определение номера координатной четверти");
        Console.WriteLine("Введите координаты точки (X и Y):");

        Console.Write("X: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            Console.Write("Y: ");
            if (double.TryParse(Console.ReadLine(), out double y))
            {
                int quadrant = GetQuadrantNumber(x, y);
                Console.WriteLine($"Точка с координатами ({x}, {y}) находится в {quadrant}-й координатной четверти.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод для Y. Введите число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для X. Введите число.");
        }

        // Пример 3: Определение наибольшей цифры в числе
        Console.WriteLine("\nПример 3: Определение наибольшей цифры в числе");
        Console.WriteLine("Введите целое число из отрезка [10, 99]:");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 10 && number <= 99)
            {
                int maxDigit = GetMaxDigit(number);
                Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}.");
            }
            else
            {
                Console.WriteLine("Число не находится в указанном диапазоне [10, 99].");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }

        // Пример 4: Вывод цифр числа через запятую
        Console.WriteLine("\nПример 4: Вывод цифр числа через запятую");
        Console.WriteLine("Введите натуральное число N:");

        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"Цифры числа {n} через запятую: {GetDigitsSeparatedByComma(n)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите натуральное число.");
        }
    }

     // Пример 1: Проверка кратности числа 7 и 23
    static bool IsMultipleOfSevenAndTwentyThree(int n)
    {
        return n % 7 == 0 && n % 23 == 0;
    }


   // Пример 2: Определение номера координатной четверти
    static int GetQuadrantNumber(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else if (x > 0 && y < 0)
        {
            return 4;
        }
        else
        {
            return 0;
        }
    }

    // Пример 3: Определение наибольшей цифры в числе
    static int GetMaxDigit(int n)
    {
        int maxDigit = 0;

        while (n > 0)
        {
            int digit = n % 10;
            maxDigit = Math.Max(maxDigit, digit);
            n /= 10;
        }

        return maxDigit;
    }

    // Пример 4: Вывод цифр числа через запятую
    static string GetDigitsSeparatedByComma(int number)
    {
        string result = "";

        while (number > 0)
        {
            int digit = number % 10;
            result = digit + (result == "" ? "" : ", " + result);
            number /= 10;
        }

        return result;
    }