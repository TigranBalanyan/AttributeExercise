using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAttribues
{
    [DisplayAttribute(ConsoleColor.Green)]
    public class Person
    {
        [DisplayAttribute(ConsoleColor.Magenta)]
        public string Name { get; set; }

        public int AgeInYears { get; set; }

        public Person(string name, int ageInYears)
        {
            this.Name = name;
            this.AgeInYears = ageInYears;
        }
    }
}
