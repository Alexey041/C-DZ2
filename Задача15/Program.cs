Console.Clear();
Console.WriteLine("Введите число от 1 до 7 ");
int a = int.Parse(Console.ReadLine());

if ((a >= 1) & (a <= 7))
{
    if (a == 6) 
    {
        Console.WriteLine("Да");
    }

    else if (a == 7)
    {
        Console.WriteLine("Да");
    }

    else
    {
        Console.WriteLine("Нет");
    }
}

else
{
    Console.WriteLine("Число не входит в заданный диапазон");
}