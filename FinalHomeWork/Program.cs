﻿using FinalHomeWork;

Main();

static void Main()
{
    int num1 = 0;
    int num2 = 0;
    Console.WriteLine("введите целое число1-начало");
    try
    {
        num1 = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("нужно вводить целое число");
    }

    Console.WriteLine("введите число2-конец");

    try
    {
        num2 = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("нужно вводить целое число");
    }

    new Task1().RecursionPrint(num1, num2);
    Console.WriteLine("nфункция аккермана:");
    Console.WriteLine(new Task2().AkkermanFunction(num1, num2));
}