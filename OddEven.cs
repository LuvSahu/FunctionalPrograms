using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class OddEven
    {
        public int num1, rem1;
        public void OddEvenCheck()
        {
        Console.Write("Check whether a number is even or odd :\n");
        Console.Write("Input an number : ");
        num1= Convert.ToInt32(Console.ReadLine()); 
        rem1 = num1 % 2;
        if (rem1 == 0)
        Console.WriteLine("{0} is an even number.\n",num1);
        else
        Console.WriteLine("{0} is an odd number.\n",num1);

        }

    }
}
