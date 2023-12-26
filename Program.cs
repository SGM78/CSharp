{
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