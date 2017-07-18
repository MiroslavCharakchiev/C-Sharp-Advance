using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vihicles
{
    class Truck : Vehicle
    {
        public const double adition = 1.6;
        public Truck(double quantity, double kmPerLiters) : base(quantity, kmPerLiters)
        {
            this.KmPerLiter = kmPerLiters;
        }

        public double KmPerLiter
        {
            get { return base.KmPerLiter; }
            set { base.KmPerLiter += adition; }
        }

        public override double Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return this.Quantity;
            }
            else
            {
                return base.Quantity += (liters * 0.95);
            }
        }

        public override string ToString()
        {
            return $"Truck: {this.Quantity:f2}";
        }
    }
}
