Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
String? response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max+1);
    response = "";

    while(guess != number)
    {
        System.Console.Write("Guess a number between " + min + " - " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Guess: " + guess);

        if (guess > number)
        {
            System.Console.WriteLine(guess + " is too high!");
        } else if (guess < number)
        {
            System.Console.WriteLine(guess + " is too low!");
        }
        guesses++;
    }
    System.Console.WriteLine("Number: " + number);
    System.Console.WriteLine("YOU WIN!");
    System.Console.WriteLine("Guesses: " + guesses);

    System.Console.Write("Would you like do play again? (Y/N): ");
    response = Console.ReadLine();
    response = response?.ToUpper();

    if(response == "Y")
    {
        playAgain = true;
    } else
    {
        playAgain = false;
    }
}

System.Console.WriteLine("Thanks for playing!");