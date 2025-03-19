namespace _7_VowelOrConsonant
{
    internal class VowelOrConsonant
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if(letter is 'A' or 'a' or 'E' or 'e' or 'I' or 'i' or 'O' or 'o' or 'U' or 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}