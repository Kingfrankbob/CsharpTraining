namespace frootLoops
{
    public class program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            int choice = getInput.getChoice();
            switch (choice)
            {

                case 1:
                    cherryOne.threeDone();
                    program.Main();
                    break;
                
                case 2:
                    appleTwo.itOkay();
                    program.Main();
                    break;

                case 3:
                    kiwiThree.kwFactor();
                    program.Main();
                    break;

                // case 4:
                    //problemFour.SpeedCamera();
                    //program.Main();
                //     break;

                // case 5:
                    // Console.ForegroundColor = ConsoleColor.Green;
                    // Console.WriteLine("\nGoodbye\n");
                    // Console.ForegroundColor = ConsoleColor.Gray;
                    // Console.Beep();
                    // Console.Beep();
                //     break;

                default:
                    // Console.WriteLine("Invalid Input");
                    // program.Main();
                    break;
                    
            }
        }
    }
}
