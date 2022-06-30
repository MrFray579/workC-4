void coordinate (int x, int y)
{
    if (x > 0 && y > 0)
    Console.WriteLine("Первая четверть");
    else if (x < 0 && y > 0)
    Console.WriteLine("Вторая четверть");
    else if (x < 0 && y < 0)
    Console.WriteLine("Третья четверть");
    else if (x > 0 && y < 0)
    Console.WriteLine("Четвертая четверть");
}

coordinate (3,6);
coordinate (-3,6);
coordinate (-3,-6);
coordinate (3,-6);