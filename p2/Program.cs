namespace UserInput
{
    class program
    {
        static void Main()
        {
            int choice = getInput.getChoice();
            switch (choice)
            {

                case 1:
                    problemOne.Validation();
                    program.Main();
                    break;

                case 2:
                    problemTwo.BiggerOfTwo();
                    program.Main();
                    break;

                case 3:
                    problemThree.LandscapeOrPortrait();
                    program.Main();
                    break;

                case 4:
                    problemFour.SpeedCamera();
                    program.Main();
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
                    program.Main();
                    break;
            }
        }
    }
}
