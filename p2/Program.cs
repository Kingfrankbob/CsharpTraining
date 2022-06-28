
namespace UserInput
{

        static void Main(string[] args){

            Console.WriteLine("Please select a program to run:\n1.Number Validation\n2.Which is bigger?");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){

                case 1:
                UserValidation.Validation();
                break; 

            }
            


        }

    
        static void BiggerofTwo()
        {
            int first = 0, second = 0;
            Console.WriteLine("Enter the first number\n");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number\n");
            second = int.Parse(Console.ReadLine());
            if(first > second){
                Console.WriteLine("First is bigger then second being {0}", first);

            } 
            else if(second > first){
                Console.WriteLine("Second is bigger then first being: {0}", second);
            }
            else 
            {
                Console.WriteLine("Sorry cant help you there");
            }
        }
    }
}