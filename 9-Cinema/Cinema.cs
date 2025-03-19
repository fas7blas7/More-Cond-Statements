namespace _9_Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int countOfRows = int.Parse(Console.ReadLine());
            int countOfSeats = int.Parse(Console.ReadLine());
            
            double priceOfTicket = 0;
            double totalCountOfSeats = 0;
            if (typeOfMovie == "Premiere")
            {
                priceOfTicket = 12.00;
                totalCountOfSeats = countOfRows * countOfSeats;
                Console.WriteLine($"{totalCountOfSeats * priceOfTicket:f2}");
            }
            else if (typeOfMovie == "Normal")
            {
                priceOfTicket = 7.50;
                totalCountOfSeats = countOfRows * countOfSeats;
                Console.WriteLine($"{totalCountOfSeats * priceOfTicket:f2}");
            }
            else if (typeOfMovie == "Discount")
            {
                priceOfTicket = 5.00;
                totalCountOfSeats = countOfRows * countOfSeats;
                Console.WriteLine($"{totalCountOfSeats * priceOfTicket:f2}");
            }
        }
    }
}