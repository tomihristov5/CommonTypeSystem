// Problem 4. Person class
// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
// Override ToString() to display the information of a person and if age is not specified – to say so.
// Write a program to test this functionality.

namespace _04.PersonClass
{
    using System;

    public static class TestPerson
    {
        public static void Main()
        {
            var person = new Person("Gosho Petrov", 19);
            var anotherPerson = new Person("Tosho Ivanov");
            var yetAnotherPerson = new Person("Pesho Hristov", null);

            Console.WriteLine(person);
            Console.WriteLine(anotherPerson);
            Console.WriteLine(yetAnotherPerson);
        }
    }
}
