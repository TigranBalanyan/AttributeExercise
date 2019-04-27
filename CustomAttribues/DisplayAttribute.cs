using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAttribues
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.All, AllowMultiple = true)]
    public class DisplayAttribute : Attribute
    {
        public ConsoleColor Color { get; set; }
        public DisplayAttribute(ConsoleColor color)
        {
            this.Color = color;
        }

    }
}
