using System;

namespace Exercises
{
    public class Person {
        public string? FirstName;
        public string? LastName;
        public int Age;

        public void Introduce() {
            Console.WriteLine("Hi, my name is " + FirstName + " " + LastName);
        }

        public static void MakeOld(Person person){
            person.Age += 10;
        }
    }
}

