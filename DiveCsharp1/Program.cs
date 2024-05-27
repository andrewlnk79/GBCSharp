using System.Runtime.InteropServices;

namespace DiveCsharp1
    {
    internal class Program
        {


        static void Main(string[] args)
            {


            if (args.Length == 3)
                {

                var number1 = Convert.ToInt32(int.Parse(args[0]));
                var operation = args[1];
                var number2 = Convert.ToInt32(int.Parse(args[2]));
                int result = 0;
                switch (operation)
                    {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;

                    }
                Console.WriteLine($"результатоперации{operation}={result}");
                }
            else
                {
                Console.WriteLine("введены неверные значения");
                }


            }
        }
    }
