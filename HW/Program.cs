﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите число a: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int j = int.Parse(Console.ReadLine());
if (i > j) {
    Console.WriteLine(i);
}
else{

    Console.WriteLine(j);
}