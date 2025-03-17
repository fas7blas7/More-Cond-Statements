namespace _3_BonusScore
{
    internal class BonusScore
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonusScore = 0;

            if (number >= 0 && number <= 3)
            {
                bonusScore = number + 5;
                Console.WriteLine($"{bonusScore}");
            }
            else if(number >= 4 && number <= 6)
            {
                bonusScore = number + 15;
                Console.WriteLine($"{bonusScore}");
            }
            else if (number >= 7 && number <= 9)
            {
                bonusScore = number + 20;
                Console.WriteLine($"{bonusScore}");
            }
        }
    }
}