namespace DiveCSharpFinal
    {
    internal class Program
        {
        private static void Main(string[] args)
            {
            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            int[] ChangedArray = array.Cast<int>().ToArray();
            Array.Sort(ChangedArray);

            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                {
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                    array[i, j] = ChangedArray[index++];
                    Console.WriteLine("Отсортированный массив:");
                    for (int l = 0; l < array.GetLength(0); l++)
                        {
                        for (int k = 0; k < array.GetLength(1); k++)
                            {
                            Console.Write(+array[l, k] + " ");
                            }

                        Console.WriteLine();
                        }

                    }
                }
            }
        }
    }

