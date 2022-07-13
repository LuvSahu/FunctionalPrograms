using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Factors
    {
        public void Factor()
        {
            Console.WriteLine("Enter the Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prime Factors for are " + Number);
            for (int i = 2; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
