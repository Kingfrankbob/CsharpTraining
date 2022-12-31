namespace UserInput
{
    class program
    {
        static void MainColors()
        {
            int choice = getInput.getChoice();
            switch (choice)
            {

                case 1:
                    problemOne.Validation();
                    program.MainColors();
                    break;

                case 2:
                    problemTwo.BiggerOfTwo();
                    program.MainColors();
                    break;

                case 3:
                    problemThree.LandscapeOrPortrait();
                    program.MainColors();
                    break;

                case 4:
                    problemFour.SpeedCamera();
                    program.MainColors();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGoodbye\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Beep();
                    Console.Beep();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    program.MainColors();
                    break;
            }
        }
    }
}
