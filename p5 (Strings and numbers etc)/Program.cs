namespace yarn
{
    public class program
    {
        public static void MainYarn()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            int choice = getInput.getChoice();
            switch (choice)
            {

                case 1:
                    Amaranth.Consornt();
                    program.MainYarn();
                    break;

                case 2:
                    vermilion.duplicato();
                    program.MainYarn();
                    break;

                case 3:
                    yellow.timeToStop();
                    program.MainYarn();
                    break;

                case 4:
                    green.PascalCase();
                    program.MainYarn();
                    break;

                case 5:
                    blue.VowelCounter();
                    program.MainYarn();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGoodbye\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Beep();
                    Console.Beep();
                    break;

                default:
                    break;
            }
        }
    }
}
