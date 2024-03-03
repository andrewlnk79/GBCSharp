using System.Drawing;

namespace FinalHomeWork;

public class Task3
{
    public int size { get; set; }

    public int ConsoleReadArraySize()
    {
        Console.WriteLine("введите размер массива");
        try
        {
            size = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("нужно вводить целое число");
        }

        return size;
    }


    public int[] CreateArray(int size)
    {
        Random rnd = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(1, 10);
        }

        return array;
    }

    public void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(i + " ");
        }
    }

    public int index { get; set; }

    public int LastIndexArray(int[] array)
    {
        return index = array.Length - 1;
    }


    public void ReversArray(int[] array, int index)
    {
        if (index <= 0)
            return;
        Console.Write(array[index]
                      + " ");
        ReversArray(array, index - 1);
    }
}