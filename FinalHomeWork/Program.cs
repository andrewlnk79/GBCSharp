using System.Threading.Channels;
using FinalHomeWork;

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
    Console.WriteLine("ниже все про массив:");

    Task3 task3 = new Task3();
    int Size = task3.ConsoleReadArraySize();
    int index = task3.LastIndexArray(task3.CreateArray(Size));
    Console.WriteLine("index=" + index);
    Console.WriteLine("получили массив:");
    task3.PrintArray(task3.CreateArray(Size));
    Console.WriteLine("\nразвернули массив:");
    task3.ReversArray(task3.CreateArray(Size), index);
}