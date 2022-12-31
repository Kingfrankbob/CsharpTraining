namespace frootLoops
{
    public class program
    {
        static void MainFruits()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            int choice = getInput.getChoice();
            switch (choice)
            {

                case 1:
                    cherryOne.threeDone();
                    program.MainFruits();
                    break;

                case 2:
                    appleTwo.itOkay();
                    program.MainFruits();
                    break;

                case 3:
                    kiwiThree.kwFactor();
                    program.MainFruits();
                    break;

                case 4:
                    blueberryFour.randomNumberGuess();
                    program.MainFruits();
                    break;

                case 5:
                    strawberryFive.MMMck();
                    program.MainFruits();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGoodbye\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Beep();
                    Console.Beep();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    program.MainFruits();
                    break;

            }
        }
    }
}
