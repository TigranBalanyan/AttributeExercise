using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CustomAttribues
{
    public class PersonPrinter
    {
        public PersonPrinter(Person myPerson)
        {
            MyPerson = myPerson;
        }
        public Person MyPerson { get; set; }

        public void Print()
        {
            PropertyInfo nameProperty = typeof(Person).GetProperty("Name");
            DisplayAttribute colorProperty = (DisplayAttribute)Attribute.GetCustomAttribute(nameProperty, typeof(DisplayAttribute));

            DisplayAttribute classProperty = (DisplayAttribute)Attribute.GetCustomAttribute(typeof(Person), typeof(DisplayAttribute));

            if (colorProperty != null)
            {
                Console.ForegroundColor = colorProperty.Color;
            }
            if(classProperty != null)
            {
                Console.BackgroundColor = classProperty.Color;
            }
                
            Console.WriteLine($"Person's name is - {this.MyPerson.Name}");

            ResetColor();

            Console.WriteLine($"Person's age is - {this.MyPerson.AgeInYears}");
        }

        private void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
