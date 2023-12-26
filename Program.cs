Console.WriteLine("Введите целое число из отрезка [10, 99]:");
    {
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
    }

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