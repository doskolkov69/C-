﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("введите N: ");
int s = int.Parse(Console.ReadLine());
int i = 1;
while (i <= s)
{
    if (i % 2 ==0)
    {
        Console.Write(i + " , ");
        i++;
    }
    i++;
}
