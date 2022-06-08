using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            float Harmonic_result = 0;
            Console.WriteLine("Enter the value of  N for nth  Harmonic ");
            int Num = Convert.ToInt32(Console.ReadLine());
            while (Num == 0)
            {
                Console.WriteLine("Enter the vaild input");
                Num = Convert.ToInt32(Console.ReadLine());
            }
            for (float i = 1; i < Num; i++)
            {
                Harmonic_result += 1 / i;
            }
            Console.WriteLine("The Harmonic number is " + Harmonic_result);
        }

    }
}
