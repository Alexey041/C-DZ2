//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Clear();
Console.WriteLine("Введите число ");
int a = Math.Abs(int.Parse(Console.ReadLine()));
int rate = 10;
int count = 1;

//находим насколько большое число с помощью степеней 10 и с помощью
//деления с остатком определяем нужное число

if (a > 99)
{
    while (rate <= a)    
    {                     
        rate = rate * 10; 
        count++;          
    }

    int q = rate / 100;
    int remainder = a % q;      //остаток
    count = count - 3;  
    int devision = 10;          //деление
    devision = Convert.ToInt32(Math.Pow(devision, count)); 
    int result = remainder / devision; 
    Console.WriteLine(result);
    
}

if (a < 99)
{
    Console.WriteLine("Третьего числа нет");
}
