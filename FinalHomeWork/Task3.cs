using System.Drawing;

namespace FinalHomeWork;

public class Task3
{
    public int size = 0;

    public int ConsoleReadArraySize()
    {
        Console.WriteLine("введите размер массива");
        try
        {
            int size = Convert.ToInt32(Console.ReadLine());
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
        int[] array = new int[this.size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 100);
        }

        return array;
    }

    public void PrintArray(int[] array)
    {
        foreach (var it in array)
        {
            Console.WriteLine(it);
        }
    }

    public int index { get; set; }

    public int LastIndexArray(int[] array)
    {
        return index = array.Length - 1;
    }


    public void ReversArray(int[] array, int index)
    {
        if (this.index < 0)
            return;
        Console.Write(array[this.index]
                      + " ");
        ReversArray(array, index - 1);
    }
}