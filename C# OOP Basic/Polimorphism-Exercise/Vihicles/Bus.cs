using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Vihicles
{
    class Bus : Vehicle
    {
        private double tank;
        private  double adition = 1.4;
        private double normalFuelConsumption;
        public Bus(double quantity, double kmPerLiters, double tank) : base(quantity, kmPerLiters)
        {
            this.tank = tank;
            this.adition += kmPerLiters;
            this.normalFuelConsumption = kmPerLiters;

        }

        public override double Refuel(double liters)
        {
            if (this.tank - base.Quantity < liters)
            {
                Console.WriteLine("Cannot fit in tank");
                return base.Quantity;
            }
            else
            {
              return  this.Refuel(liters);
            }
        }

        public override string ToString()
        {
            return $"Bus: {this.Quantity:f2}";
        }

        public double BusStatus(double kilometers, string status)
        {
            if (status == "empty")
            {
                base.KmPerLiter = normalFuelConsumption;
                return this.Drive(kilometers);
            }
            else
            {
                 base.KmPerLiter = adition;
               return this.Drive(kilometers);
            }
        }
        
    }
}
