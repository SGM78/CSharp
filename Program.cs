 Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 7 == 0 && num % 23 == 0)
        {
            Console.WriteLine("{0} кратно 7 и 23", num);
        } 
        else 
        {
            Console.WriteLine("{0} не кратно 7 и 23", num);
        }    