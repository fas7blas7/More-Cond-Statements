namespace _1_Marketplace
{
    internal class Marketplace
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double bananaPrice = 0;
            double applePrice = 0;
            double kiwiPrice = 0;

            if (day == "Weekday" && product == "Banana")
            {
                bananaPrice = 2.50;
                Console.WriteLine($"{bananaPrice:F2}");
            }
            else if (day == "Weekday" && product == "Apple")
            {
                applePrice = 1.30;
                Console.WriteLine($"{applePrice:F2}");
            }
            else if (day == "Weekday" && product == "Kiwi")
            {
                kiwiPrice = 2.20;
                Console.WriteLine($"{kiwiPrice:F2}");
            }
            else if (day == "Weekend" && product == "Banana")
            {
                bananaPrice = 2.70;
                Console.WriteLine($"{bananaPrice:F2}");
            }
            else if (day == "Weekend" && product == "Apple")
            {
                applePrice = 1.60;
                Console.WriteLine($"{applePrice:F2}");
            }
            else if (day == "Weekend" && product == "Kiwi")
            {
                kiwiPrice = 3.00;
                Console.WriteLine($"{kiwiPrice:F2}");
            }
        }
    }
}