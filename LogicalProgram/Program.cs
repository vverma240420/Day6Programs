namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems");
            Console.WriteLine("\n1:FibanocciSeries\n2:PerfectNumber\n3:PrimeNumber\n4:ReverseNumber\n5:CouponNumber\n11:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonacciSeries.Fibanocci();
                    break;
                case 2:
                    PerfectNumber.perfectNo();
                    break;
                case 3:
                    PrimeNumber.PrimeOrNot();
                    break;
                case 4:
                    ReverseNumber.Reversing();
                    break;
                case 5:
                    CouponNumber.CouponGenerator();
                    break;
                default:
                    Console.WriteLine("Enter the Above Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}