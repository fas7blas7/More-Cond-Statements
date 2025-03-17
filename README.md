# GitHub Repository

Welcome to my GitHub repository! Here you will find various coding tasks with their respective implementations.

## 🚀 Coding Tasks

### 1️⃣ Marketplace 🛒
**Namespace:** `_1_Marketplace`

**Description:**
A simple program that determines the price of a product based on the day of the week.

```csharp
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
```
---

### 2️⃣ Largest Number 🔢
**Namespace:** `_2_LargestNumber`

**Description:**
A program that determines the largest of three numbers.

```csharp
namespace _2_LargestNumber
{
    internal class LargestNumberOutOfThree
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"{firstNumber}");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"{secondNumber}");
            }
            else
            {
                Console.WriteLine($"{thirdNumber}");
            }
        }
    }
}
```
---

### 3️⃣ Bonus Score 🎯
**Namespace:** `_3_BonusScore`

**Description:**
A program that assigns bonus points based on an input number.

```csharp
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
```
