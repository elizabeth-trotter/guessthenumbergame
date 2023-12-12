// Name: Elizabeth Trotter

// Date Revised: 9/15/2023

// Exercise: Mini Challenge # 8 - Guess It

// Brief Description: Create a guessing game in a brand new console project. 
//                    Use Random function to select a number.
//                    Print if guess is higher or lower than the number guessed.
//                    Keep track of the number of guesses it took for user to get the number.
//                    Make it where the user can choose easy, medium, or hard mode before they begin. (Easy = 1 to 10, Medium = 1 to 50, Hard = 1 to 100)
//                    Extra Credit: Allow the user to enter in the number range to guess. (Custom mode)

// Peer Review: Tommy Ngo
// Everything runs as intended and looks perfect. Great start to the year! :)

Console.Clear();

Console.WriteLine("Mini Challenge # 8 - Guess It");
void Break(){
    string breakPoint = ("----------------------------------");
    Console.WriteLine(breakPoint);
}
Break();
Console.WriteLine("INSTRUCTIONS: Today, we will play a game in which you will try to guess a random number. I will provide hints along the way and keep track of how many guesses you made before getting the right answer. Try to win the game with the least amount of guesses possible! There will be 4 different modes of difficulty for you to choose from that will determine the range of whole numbers we'll be working with. **Easy (1-10), Medium (1-50), Hard (1-100), or Custom (YOU choose the range)** Be sure to try out the custom mode for some EXTRA fun! Good luck!");
Break();

int guessNum;
int i;
void ValidNum(string range){
    bool success = true;
    Break();
    Console.Write($"Please guess a number between {range}: ");
    while (success != Int32.TryParse(Console.ReadLine(), out guessNum)){
        Console.Write("Input invalid! You must enter a whole number: ");
    }
    Break();
    i++;
}

int minRange;
int maxRange;
void ValidNumCustom(){
    bool success = true;
    Break();
    Console.WriteLine("Okay, customizer! Let's choose some whole numbers!");
    Console.Write($"Please enter your MINIMUM range value: ");
    while (success != Int32.TryParse(Console.ReadLine(), out minRange)){
        Console.Write("Input invalid! You must enter a whole number: ");
    }
    Console.Write($"Next, please enter your MAXIMUM range value (must be greater than your minimum): ");
    while (success != Int32.TryParse(Console.ReadLine(), out maxRange) || minRange >= maxRange){
        Console.Write("Input invalid! You must enter a whole number greater than your minimum range value: ");
    }
    Console.WriteLine("Thanks, I've got your custom range!");
}

Random actual = new Random();
int actualNum;

bool modeInvalid = true;
while(modeInvalid){
    Console.WriteLine("Please choose a mode (easy, medium, hard, or custom): ");
    string? mode = Console.ReadLine();
    i = 0;
    if(mode == "easy"){
        modeInvalid = false;
        ValidNum("1 - 10");
        actualNum = actual.Next(1, 11);
        bool incorrectNum = true;
        while(incorrectNum){
            if(guessNum > actualNum){
                Console.WriteLine("HINT: Your chosen number was GREATER than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 10");
            }else if(guessNum < actualNum){
                Console.WriteLine("HINT: Your chosen number was LESS than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 10");
            }else{
                Console.WriteLine("** You guessed the number, great job! **");
                Console.WriteLine($"It took you {i} guess(es) to get the right number.");
                Break();
                bool invalFormat = true;
                while(invalFormat){
                    Console.WriteLine("Would you like to play again? (Enter yes or no)");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if(userAns == "no"){
                        incorrectNum = false;
                        invalFormat = false;
                        Break();
                        Console.WriteLine("Thanks for playing!");
                        Break();
                    }else if(userAns == "yes"){
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }else{
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }else if(mode == "medium"){
        modeInvalid = false;
        ValidNum("1 - 50");
        actualNum = actual.Next(1, 51);
        bool incorrectNum = true;
        while(incorrectNum){
            if(guessNum > actualNum){
                Console.WriteLine("HINT: Your chosen number was GREATER than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 50");
            }else if(guessNum < actualNum){
                Console.WriteLine("HINT: Your chosen number was LESS than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 50");
            }else{
                Console.WriteLine("** You guessed the number, great job! **");
                Console.WriteLine($"It took you {i} guess(es) to get the right number.");
                Break();
                bool invalFormat = true;
                while(invalFormat){
                    Console.WriteLine("Would you like to play again? (Enter yes or no)");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if(userAns == "no"){
                        incorrectNum = false;
                        invalFormat = false;
                        Break();
                        Console.WriteLine("Thanks for playing!");
                        Break();
                    }else if(userAns == "yes"){
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }else{
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }else if(mode == "hard"){
        modeInvalid = false;
        ValidNum("1 - 100");
        actualNum = actual.Next(1, 101);
        bool incorrectNum = true;
        while(incorrectNum){
            if(guessNum > actualNum){
                Console.WriteLine("HINT: Your chosen number was GREATER than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 100");
            }else if(guessNum < actualNum){
                Console.WriteLine("HINT: Your chosen number was LESS than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum("1 - 100");
            }else{
                Console.WriteLine("** You guessed the number, great job! **");
                Console.WriteLine($"It took you {i} guess(es) to get the right number.");
                Break();
                bool invalFormat = true;
                while(invalFormat){
                    Console.WriteLine("Would you like to play again? (Enter yes or no)");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if(userAns == "no"){
                        incorrectNum = false;
                        invalFormat = false;
                        Break();
                        Console.WriteLine("Thanks for playing!");
                        Break();
                    }else if(userAns == "yes"){
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }else{
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }else if(mode == "custom"){ //**EXTRA CREDIT**
        modeInvalid = false;
        ValidNumCustom();
        ValidNum($"{minRange} - {maxRange}");
        actualNum = actual.Next(minRange, maxRange);
        bool incorrectNum = true;
        while(incorrectNum){
            if(guessNum > actualNum){
                Console.WriteLine("HINT: Your chosen number was GREATER than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum($"{minRange} - {maxRange}");
            }else if(guessNum < actualNum){
                Console.WriteLine("HINT: Your chosen number was LESS than the actual number.");
                Console.WriteLine("Try again and let's see if we can get closer this time!");
                ValidNum($"{minRange} - {maxRange}");
            }else{
                Console.WriteLine("** You guessed the number, great job! **");
                Console.WriteLine($"It took you {i} guess(es) to get the right number.");
                Break();
                bool invalFormat = true;
                while(invalFormat){
                    Console.WriteLine("Would you like to play again? (Enter yes or no)");
                    string? userAns = Console.ReadLine()?.ToLower();
                    if(userAns == "no"){
                        incorrectNum = false;
                        invalFormat = false;
                        Break();
                        Console.WriteLine("Thanks for playing!");
                        Break();
                    }else if(userAns == "yes"){
                        modeInvalid = true;
                        incorrectNum = false;
                        invalFormat = false;
                    }else{
                        Console.WriteLine("Sorry I didn't get that...");
                        Break();
                    }
                }
            }
        }
    }else{
        Console.WriteLine("Sorry I didn't get that...");
        Break();
    }
}


