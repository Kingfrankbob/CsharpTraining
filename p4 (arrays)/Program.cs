namespace Vacashon
{
    class program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            int choice = getInput.getChoice();
            switch (choice)
            {

                case 1:
                    NYC_ONE.noFriends();
                    program.Main();
                    break;

                case 2:
                    madagascarTwo.Reversi();
                    program.Main();
                    break;

        case 3:
          MexicoThree.numberAsk();
          program.Main();
          break;

                // case 4:
                //   blueberryFour.randomNumberGuess();
                //   program.Main();
                //   break;

                case 5:
                  moscowFive.Smallestofall();
                  program.Main();
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
                    program.Main();
                    break;

            }
        }
    }
  }


