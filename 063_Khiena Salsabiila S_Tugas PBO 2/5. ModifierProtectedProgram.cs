using System;
using System.Collections;

namespace ModifierProtected
{
    class Person
    {
        protected string name = "Khiena";
    }

    class Program : Person
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.name);
            Console.ReadLine();
        }
    }

}