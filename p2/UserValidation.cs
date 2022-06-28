
namespace UserInput
{
    static class UserValidation
    {
        static void Validation()
        {
            Console.WriteLine("Enter a Valid Number\n ofc between 1 & 10");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber <= 10 && inputNumber >= 1)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }
        }
    }

}