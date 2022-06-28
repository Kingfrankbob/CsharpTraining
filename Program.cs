using System;
using Exercises.Math;



//  \n  \t  \\  \'  \"   Special Characters. 


namespace Exercises
{
    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {

           // var methodName = "Express";
           // var shippingMethod  = (string) Enum.Parse(typeof(ShippingMethod), methodName);
           // Console.WriteLine(shippingMethod);



            Person John = new Person();
            John.FirstName = "Johnathan";
            John.LastName = "Leavitt";
            John.Age = 30;



            try
            {

                John?.Introduce();
                Console.WriteLine(John.Age);
                Person.MakeOld(John);
                Console.WriteLine(John.Age);

            }


            catch (System.Exception)
            {
                Console.Beep();
            }


        }
    }
}

