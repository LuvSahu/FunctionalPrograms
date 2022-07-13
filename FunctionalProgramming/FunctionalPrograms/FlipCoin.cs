using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class FlipCoin
    {
        public void CoinFlip()
        {
            int Head = 0;
            int Teal = 0;
            Console.WriteLine("Enter the number of times you want to flip coin :");
            int Number_of_flip = Convert.ToInt32(Console.ReadLine());

            while (Number_of_flip <= 0)
            {
                Console.WriteLine("Invaild input, please a vaild input greater then 0 :");
                Number_of_flip = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < Number_of_flip; i++)
            {
                Random flip = new Random();
                int result = flip.Next(0, 2);
                if (result < 0.5)
                {
                    Head++;
                }
                else
                {
                    Teal++;
                }
            }
            float Head_per = (float)Head * 100 / Number_of_flip;
            float Teal_per = (float)Teal * 100 / Number_of_flip;


            Console.WriteLine(Head_per + " % of the times the result of head ");
            Console.WriteLine(Teal_per + " % of the times the result of teals ");

        }
    }
}
