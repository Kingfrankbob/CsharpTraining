using System.Text;
namespace Vacashon
{
    class moscowFive
    {
        public static void Smallestofall()
        {
            List<string> numbers = new List<string>();
            int Previous = 2147483647;
            string toap;

            Console.WriteLine("Enter a string of Numbers: (Seperated by a Comma)");
            string? input = Console.ReadLine();
            if (input == null)
            {
                while (input == null)
                {
                    Console.WriteLine("At least put someting!!!!");
                    Console.WriteLine("Enter a string of Numbers: (Seperated by a Comma)");
                    input = Console.ReadLine();
                }
            }

            var sb = new StringBuilder();

            foreach (char value in input)
            {
                int truvalue = (int)Char.GetNumericValue(value);

                if (truvalue <= 9 && truvalue >= 0)
                {
                    sb.Append(value);
                }
                else if (truvalue > 9 || truvalue < 0)
                {
                    toap = sb.ToString();
                    numbers.Add(toap);
                    sb = new StringBuilder();
                }
            }

            toap = sb.ToString();
            numbers.Add(toap);

            for(int i = 0; i < 3; i++)
            foreach (string str in numbers)
            {
                try
                {
                    int thisss = int.Parse(str);
                    if (thisss < Previous) Previous = thisss;
                }
                catch (Exception)
                {
                    //Do nothing
                }
            }
        }
    }
}