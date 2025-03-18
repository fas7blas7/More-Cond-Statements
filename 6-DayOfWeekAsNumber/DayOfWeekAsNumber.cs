namespace _6_DayOfWeekAsNumber
{
    internal class DayOfWeekAsNumber
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            if (dayOfWeek == 1)
            {
                Console.WriteLine("Monday");
            }
            if (dayOfWeek == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (dayOfWeek == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (dayOfWeek == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (dayOfWeek == 5)
            {
                Console.WriteLine("Friday");
            }
            if (dayOfWeek == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (dayOfWeek == 7)
            {
                Console.WriteLine("Sunday");
            }
            else if (dayOfWeek < 1 || dayOfWeek > 7)
            {
                Console.WriteLine("Error");
            }
        }
    }
}