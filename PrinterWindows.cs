using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("\nprinter display dimension: ");
        }
        public virtual void Print()
        {
            Console.WriteLine("printer printing...");
        }
    }
}