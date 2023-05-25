namespace Hangman
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Black;
            string words = "vegetable";
            //List<string> words = new List<string> { "vegetable", "carrot", };
            Console.Clear();
            string displayWord = new string('_', words.Length);

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            int incorrectGuesses = 0;
            bool done = false;

            
            Console.WriteLine("Hangman Game");
            
            Console.WriteLine();
            Console.WriteLine("Rules: Guess the word before the hangman is fully drawn.");

            Thread.Sleep(1500);


            while (!done)
            {
                Console.Clear();
                
                DrawHangMan(incorrectGuesses);
                Console.WriteLine();
                Console.WriteLine(displayWord);
                Console.WriteLine();

                Console.Write("Guess a letter: ");
                Console.WriteLine();
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                
                bool correct = false;
                for (int i = 0; i < words.Length; i++)
                {
                    
                    if (char.ToLower(words[i]) == char.ToLower(guess))
                    {
                        
                        displayWord = displayWord.Substring(0, i) + guess + displayWord.Substring(i + 1);
                        correct = true;
                        Console.Clear();
                    }
                }

               
                if (!correct)
                {
                    incorrectGuesses++;
                }

                
                if (incorrectGuesses == 8)
                {
                    DrawHangMan(incorrectGuesses);
                    Console.WriteLine();
                    Console.WriteLine("Game Over. The word was '{0}'.", words);
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (:C)  ");
                    Console.WriteLine("    |      /|\\ ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |      / \\ ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");

                    Console.Write("Play again? (y/n):");
                    string playAgain = Console.ReadLine();
                    Console.WriteLine();

                    switch (playAgain)
                    {
                        case "y":
                            continue;

                        case "n":
                            done = true;
                            break;

                    }
                }
                else if (!displayWord.Contains("_"))
                {
                    Console.WriteLine();
                    Console.WriteLine("You win. The word was '{0}'.", words);

                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |    (_)    ");
                    Console.WriteLine("    |    \\|/   ");
                    Console.WriteLine("    |     |     ");
                    Console.WriteLine("    |    / \\   ");
                    Console.WriteLine("____|_________  ");
                    
                    Console.Write("Play again? (y/n):");
                    string playAgain = Console.ReadLine();
                    Console.WriteLine();

                    switch (playAgain)
                    {
                        case "y":
                            continue;

                        case "n":
                            done = true;
                            break;
                         
                    }
                }
                
            }
        }
        public static void DrawHangMan(int incorrectGuesses)
        {
            switch(incorrectGuesses)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

                case 1:
                    Console.WriteLine();
                    Console.WriteLine("You have 6 more tries left.");
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("You have 5 more tries left.");
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine("You have 4 more tries left.");
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |      /|   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("You have 3 more tries left.");
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |      /|\\ ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine();
                    Console.WriteLine("You have 2 more tries left.");
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |      /|\\ ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine();
                    Console.WriteLine("You have 1 more try left.");
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |      /|\\ ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |      /    ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine();
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |      /|\\ ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |      / \\ ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    Console.WriteLine();
                    break;

            }
        }


       
    }
}