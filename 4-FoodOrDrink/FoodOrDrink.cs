namespace _4_FoodOrDrink
{
    internal class FoodOrDrink
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            if (product is "curry" or "noodles" or "sushi" or "spaghetti" or "bread")
            {
                Console.WriteLine("food");
            }
            else if (product is "coffee" or "tea" or "water" or "juice")
            {
                Console.WriteLine("drink");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}