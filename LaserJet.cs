using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nLaserJet printer display dimension: 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing...");
        }
    }
}
