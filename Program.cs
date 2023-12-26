        Console.Write("Введите координаты точки (X и Y) через пробел: ");
        String[] axis = Console.ReadLine().Split(' ');
        int x = Convert.ToInt32(axis [0]);
        int y = Convert.ToInt32(axis [1]);

        if (x > 0 && y > 0) 
        {
            Console.WriteLine("Точка ({0}, {1}) находится в первой координатной четверти", x, y);
        } 
        else if (x < 0 && y > 0) 
        {
            Console.WriteLine("Точка ({0}, {1}) находится во второй координатной четверти", x, y);
        } 
        else if (x < 0 && y < 0) 
        {
            Console.WriteLine("Точка ({0}, {1}) находится в третьей координатной четверти", x, y);
        } 
        else if (x > 0 && y < 0) 
        {
            Console.WriteLine("Точка ({0}, {1}) находится в четвёртой координатной четверти", x, y);
        }
        else
        {
            Console.WriteLine("Точка находится на оси координат");
        }

