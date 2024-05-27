using System.Runtime.InteropServices;

namespace DiveCsharp1
    {
    internal class Program
        {


        static void Main(string[] args)
            {


            if (args.Length == 3)
                {

                var number1 = Convert.ToInt32(args[0]);
                var operation = args[1];
                var number2 = Convert.ToInt32(args[2]);
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
                Console.WriteLine($"результатоперации{number1}{operation}{number2} = {result}");
                }
            else
                {
                Console.WriteLine("введены неверные значения");
                }


            }
        }
    }
