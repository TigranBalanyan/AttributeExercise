using System;

namespace CustomAttribues
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person("John", 71);
            PersonPrinter printer = new PersonPrinter(myPerson);
            printer.Print();
        }
    }
}
