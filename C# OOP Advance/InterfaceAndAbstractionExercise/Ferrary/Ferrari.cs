using System;

namespace Ferrary
{
    public class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
            this.Model = "488-Spider";
        }
        public string Model { get; }
        public string DriverName { get; }
        public void Break()
        {
            Console.Write("Brakes!");
        }

        public void Gas()
        {
            Console.Write("Zadu6avam sA!");
        }
    }
}
