using System;
using System.Collections;

namespace ModifierPublic
{
    class Person
    {
        public string name = "Khiena";
    }

    class program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.name);
        }
    }

}