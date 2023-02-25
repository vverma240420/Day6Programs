namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems");
            Console.WriteLine("\n1:FibanocciSeries\n2:PerfectNumber\n11:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonacciSeries.Fibanocci();
                    break;
                case 2:
                    PerfectNumber.perfectNo();
                    break;
                default:
                    Console.WriteLine("Enter the Above Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}