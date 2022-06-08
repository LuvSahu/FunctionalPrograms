namespace FunctionalPrograms
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Choose a number to go to the respective problem \n");
            Console.WriteLine("1 for Flip Coin");
            Console.WriteLine("2 for Leap Year");
            Console.WriteLine("3 for PowerofTwo");
            Console.WriteLine("4 for Harmonic Number");
            Console.WriteLine("5 for Factors");
            Console.WriteLine("6 for Compute Quotient and Remendier");
            Console.WriteLine("7 for Swap Number");
            Console.WriteLine("8 for Odd Even Number");
            Console.WriteLine("9 for Vowel Consonant");
            Console.WriteLine("10 for Largest Three Number");


            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin FC = new FlipCoin();
                    FC.CoinFlip();
                    break;

                case 2:
                    LeapYear LY = new LeapYear();
                    LY.Year_Leap();
                    break;

                case 3:
                    PowerofTwo PT = new PowerofTwo();
                    PT.Power();
                    break;

                case 4:
                    HarmonicNumber HN = new HarmonicNumber();
                    HN.Harmonic();
                    break;

                case 5:
                    Factors factor = new Factors();
                    factor.Factor();
                    break;

                case 6:
                    Compute comp = new Compute();
                    comp.Que_Rem();
                    break;

                case 7:
                    SwapNum SN = new SwapNum();
                    SN.SwapNumber();
                    break;

                case 8:
                    OddEven OE = new OddEven();
                    OE.OddEvenCheck();
                    break;
                case 9:
                    VowelConsoant VC = new VowelConsoant();
                    VC.VowelConsonantCheck();
                    break;
                case 10:
                    LargestThreeNum LTN = new LargestThreeNum();
                    LTN.LargestThreeNumber();
                    break;
            }




        }
    }
}
