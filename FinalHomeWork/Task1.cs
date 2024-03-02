namespace FinalHomeWork;

public class Task1
{
    public void RecursionPrint(int m, int n)
    {
        if (m > n) return;
        Console.Write(m + " ");
        RecursionPrint(m + 1, n);
    }
}