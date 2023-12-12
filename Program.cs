Console.Clear();

Console.WriteLine("Mini Challenge # 8 - Guess It");
void Break()
{
    string breakPoint = ("----------------------------------------------------------");
    Console.WriteLine(breakPoint);
}

void SlowPrint(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(30);
    }
    Console.WriteLine();
}

Break();
Console.WriteLine();
SlowPrint("INSTRUCTIONS: Today, we will play a game in which you will try to guess a random number. I will provide hints along the way and keep track of how many guesses you made before getting the right answer. Try to win the game with the least amount of guesses possible! There will be 4 different modes of difficulty for you to choose from that will determine the range of whole numbers we'll be working with. **Easy (1-10), Medium (1-50), Hard (1-100), or Custom (YOU choose the range)** Be sure to try out the custom mode for some EXTRA fun! Good luck!");
Console.WriteLine();
Break();

int guessNum;
int i;
void ValidNum(string range)
{
    bool success = true;
    Break();
    Console.WriteLine();
    Console.Write($"Please guess a number between {range}: ");
    while (success != Int32.TryParse(Console.ReadLine(), out guessNum))
    {
        Console.Write("Input invalid! You must enter a whole number: ");
    }
    Console.WriteLine();
    i++;
}

int minRange;
int maxRange;
void ValidNumCustom()
{
    bool success = true;
    Break();
    Console.WriteLine();
    SlowPrint("Okay, customizer! Let's choose some whole numbers!");
    Console.WriteLine();
    Console.Write($"Please enter your MINIMUM range value: ");
    while (success != Int32.TryParse(Console.ReadLine(), out minRange))
    {
        Console.Write("Input invalid! You must enter a whole number: ");
    }
    Console.WriteLine();
    Console.Write($"Next, please enter your MAXIMUM range value (must be greater than your minimum): ");
    while (success != Int32.TryParse(Console.ReadLine(), out maxRange) || minRange >= maxRange)
    {
        Console.Write("Input invalid! You must enter a whole number greater than your minimum range value: ");
    }
    Console.WriteLine();
    SlowPrint("Thanks, I've got your custom range! Let's see...");
}

Random actual = new Random();
int actualNum;

bool modeInvalid = true;
while (modeInvalid)
{
    Console.WriteLine();
    Console.Write("Please choose a mode (easy, medium, hard, or custom): ");
    string? mode = Console.ReadLine();
    Console.WriteLine();
    i = 0;
    if (mode == "easy")
    {
        modeInvalid = false;
        ValidNum("1 - 10");
        actualNum = actual.Next(1, 11);
        bool incorrectNum = true;
        while (incorrectNum)
        {
            if (guessNum > actualNum)
            {
                SlowPrint("HINT: Your chosen number was GREATER than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 10");
            }
            else if (guessNum < actualNum)
            {
                SlowPrint("HINT: Your chosen number was LESS than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 10");
            }
            else
            {
                Console.Write("\x1b[1m");
                SlowPrint("** You guessed it, great job! **");
                SlowPrint($"It took you {i} guess(es) to get the right number.");
                Console.ResetColor();
                Console.WriteLine();
                Break();
                bool invalFormat = true;
                while (invalFormat)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to play again? (Enter yes / no): ");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if (userAns == "no")
                    {
                        incorrectNum = false;
                        invalFormat = false;
                        Console.WriteLine();
                        SlowPrint("Thanks for playing!");
                        SlowPrint("Goodbye!");
                        Console.WriteLine();
                        Break();
                    }
                    else if (userAns == "yes")
                    {
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }
    else if (mode == "medium")
    {
        modeInvalid = false;
        ValidNum("1 - 50");
        actualNum = actual.Next(1, 51);
        bool incorrectNum = true;
        while (incorrectNum)
        {
            if (guessNum > actualNum)
            {
                SlowPrint("HINT: Your chosen number was GREATER than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 50");
            }
            else if (guessNum < actualNum)
            {
                SlowPrint("HINT: Your chosen number was LESS than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 50");
            }
            else
            {
                Console.Write("\x1b[1m");
                SlowPrint("** You guessed the number, great job! **");
                SlowPrint($"It took you {i} guess(es) to get the right number.");
                Console.ResetColor();
                Console.WriteLine();
                Break();
                bool invalFormat = true;
                while (invalFormat)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to play again? (Enter yes / no): ");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if (userAns == "no")
                    {
                        incorrectNum = false;
                        invalFormat = false;
                        Console.WriteLine();
                        SlowPrint("Thanks for playing!");
                        SlowPrint("Goodbye!");
                        Console.WriteLine();
                        Break();
                    }
                    else if (userAns == "yes")
                    {
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }
    else if (mode == "hard")
    {
        modeInvalid = false;
        ValidNum("1 - 100");
        actualNum = actual.Next(1, 101);
        bool incorrectNum = true;
        while (incorrectNum)
        {
            if (guessNum > actualNum)
            {
                SlowPrint("HINT: Your chosen number was GREATER than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 100");
            }
            else if (guessNum < actualNum)
            {
                SlowPrint("HINT: Your chosen number was LESS than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 100");
            }
            else
            {
                Console.Write("\x1b[1m");
                SlowPrint("** You guessed it, great job! **");
                SlowPrint($"It took you {i} guess(es) to get the right number.");
                Console.ResetColor();
                Console.WriteLine();
                Break();
                bool invalFormat = true;
                while (invalFormat)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to play again? (Enter yes / no): ");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if (userAns == "no")
                    {
                        incorrectNum = false;
                        invalFormat = false;
                        Console.WriteLine();
                        SlowPrint("Thanks for playing!");
                        SlowPrint("Goodbye!");
                        Console.WriteLine();
                        Break();
                    }
                    else if (userAns == "yes")
                    {
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }
    else if (mode == "custom")
    {
        modeInvalid = false;
        ValidNumCustom();
        ValidNum($"{minRange} - {maxRange}");
        actualNum = actual.Next(minRange, maxRange);
        bool incorrectNum = true;
        while (incorrectNum)
        {
            if (guessNum > actualNum)
            {
                SlowPrint("HINT: Your chosen number was GREATER than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum($"{minRange} - {maxRange}");
            }
            else if (guessNum < actualNum)
            {
                SlowPrint("HINT: Your chosen number was LESS than the actual number.");
                SlowPrint("Try again and let's see if we can get closer this time!");
                ValidNum($"{minRange} - {maxRange}");
            }
            else
            {
                Console.Write("\x1b[1m");
                SlowPrint("** You guessed it, great job! **");
                SlowPrint($"It took you {i} guess(es) to get the right number.");
                Console.ResetColor();
                Console.WriteLine();
                Break();
                bool invalFormat = true;
                while (invalFormat)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to play again? (Enter yes / no): ");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if (userAns == "no")
                    {
                        incorrectNum = false;
                        invalFormat = false;
                        Console.WriteLine();
                        SlowPrint("Thanks for playing!");
                        SlowPrint("Goodbye!");
                        Console.WriteLine();
                        Break();
                    }
                    else if (userAns == "yes")
                    {
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Sorry I didn't get that...");
        Break();
    }
}
