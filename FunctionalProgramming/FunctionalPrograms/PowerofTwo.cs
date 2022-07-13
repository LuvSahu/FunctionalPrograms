using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class PowerofTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter the Number ");
            int Number = Convert.ToInt32(Console.ReadLine());

            while (Number < 0 || Number >= 31)
            {
                Console.WriteLine("Please a enter a vaild number ");
                Number = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
