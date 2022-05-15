// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("введите целое положительное число:");
int a = int.Parse(Console.ReadLine());

if (a <= 0) 
{
Console.WriteLine("неверное число");
}
else
{
    for(int i = 1; i <= a; i++)
{
    int answer=i*i;
Console.WriteLine(answer + " ");
}
}    

