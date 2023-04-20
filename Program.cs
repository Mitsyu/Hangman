namespace Hangman
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool done = false;
            string word = "COMPUTER";
            string displayWord = "--------";
            int wrongGuess = 0;
            

            Console.WriteLine("Welcome to the Hangman Game");

            while (!done)
            {
                
            }
        }
            

        static void DrawHangMan()
        {
            switch()
            {
                case 1:
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    break;

                case 2:
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    break;

                case 3:
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    break;

                case 4:
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |      /|   ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    break;

                case 5:
                    Console.WriteLine("     _______    ");
                    Console.WriteLine("    |/      |   ");
                    Console.WriteLine("    |      (_)  ");
                    Console.WriteLine("    |      /|\\ ");
                    Console.WriteLine("    |       |   ");
                    Console.WriteLine("    |        \\ ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("____|_________  ");
                    break;

                case 6:
                    Console.WriteLine("     _______     ");
                    Console.WriteLine("    |/      |    ");
                    Console.WriteLine("    |      (_)   ");
                    Console.WriteLine("    |      /|\\  ");
                    Console.WriteLine("    |       |    ");
                    Console.WriteLine("    |      /     ");
                    Console.WriteLine("    |            ");
                    Console.WriteLine("____|_________   ");
                    break;

                case 7:
                    Console.WriteLine("     _______     ");
                    Console.WriteLine("    |/      |    ");
                    Console.WriteLine("    |      (_)   ");
                    Console.WriteLine("    |      /|\\  ");
                    Console.WriteLine("    |       |    ");
                    Console.WriteLine("    |      / \\  ");
                    Console.WriteLine("    |            ");
                    Console.WriteLine("____|_________   ");
                    break;

                case 8:
                    Console.WriteLine("     _______     ");
                    Console.WriteLine("    |/      |    ");
                    Console.WriteLine("    |            ");
                    Console.WriteLine("    |    (_)    ");
                    Console.WriteLine("    |   \\|/     ");
                    Console.WriteLine("    |     |      ");
                    Console.WriteLine("    |    / \\    ");
                    Console.WriteLine("____|_________   ");
                    break;




            }
        }


       
    }
}