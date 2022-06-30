void coordinate (int x)
{
    if (x == 1)
    Console.WriteLine("В первой четверти x > 0, y > 0");
    else if (x ==2)
    Console.WriteLine("В второй четверти x < 0, y > 0");
    else if (x == 3)
    Console.WriteLine("В третьей четверти x < 0, y < 0");
    else if (x == 4)
    Console.WriteLine("В четвертой четверти x > 0, y < 0");
    else
    Console.WriteLine("Введите число от 1 до 4");
}


coordinate (1);
coordinate (2);
coordinate (3);
coordinate (4);

/*Console.WriteLine("Введите число от 1 до 4:");
int x = Convert.ToInt32(Console.ReadLine());

 if (x == 1)
    Console.WriteLine("В первой четверти x > 0, y > 0");
    else if (x ==2)
    Console.WriteLine("В второй четверти x < 0, y > 0");
    else if (x == 3)
    Console.WriteLine("В третьей четверти x < 0, y < 0");
    else if (x == 4)
    Console.WriteLine("В четвертой четверти x > 0, y < 0");
    else
    Console.WriteLine("Введите число от 1 до 4");*/
