﻿//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int a = Math.Abs(int.Parse(Console.ReadLine()));

if ((a > 99) & (a < 1000))
{
    int b = a % 100;
    int c = b / 10;
    Console.WriteLine(c);
}

else
{
    Console.WriteLine("Число не трехзначное");
}