using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomeWork
{
    public class Task2
    {
        public int AkkermanFunction(int num1, int num2)
        {

            if (num1 == 0)
            {
                return num2 + 1;
            }
            else if (num2 == 0)
            {
                return AkkermanFunction(num1 - 1, 1);
            }
            else
            {
                return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));





            }


        }

    }
}


