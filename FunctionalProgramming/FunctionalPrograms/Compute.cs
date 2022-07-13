using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Compute
    {
        public void Que_Rem()
        {
            Console.WriteLine("Enter the Number :");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor :");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int Quoetient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;

            Console.WriteLine("Dividend: Divisor", Dividend, Divisor);
            Console.WriteLine("Quotient = " + Quoetient);
            Console.WriteLine("Remainder = " + Remainder);
        }
    }
}
