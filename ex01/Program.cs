// 17-ая задача про определение четвертей на координатной оси

Console.Write("введите значение х: ");
int x=int.Parse(Console.ReadLine ());
Console.Write("введите значение y: ");
int y=int.Parse(Console.ReadLine ());

if (x>0 && y>0)
{
    Console.WriteLine("1-ая четверть");
}

else if (x<0 && y>0)
{
    Console.WriteLine("2-ая четверть");
}
else if (x<0 && y<0)
{
    Console.WriteLine("3-ая четверть");
}

else if (x>0 && y<0)
{
    Console.WriteLine("4-ая четверть");
}