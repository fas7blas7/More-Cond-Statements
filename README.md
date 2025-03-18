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
---

### 4️⃣ Food or Drink 🍔🥤
**Namespace:** `_4_FoodOrDrink`

**Description:**
A program that classifies an input as "food" or "drink."

```csharp
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
}
```
---

### 5️⃣ Invalid Number 🚫
**Namespace:** `_5_InvalidNumber`

**Description:**
A program that checks if a number is valid based on specific conditions.

```csharp
namespace _5_InvalidNumber
{
    internal class InvalidNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || number >= 100 && number <= 200)
            {
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
```
---

### 6️⃣ Day of the Week 📅
**Namespace:** `_6_DayOfWeekAsNumber`

**Description:**
A program that prints the corresponding day name for a given number.

```csharp
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
```
