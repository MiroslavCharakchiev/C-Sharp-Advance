using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vihicles
{
    public abstract class Vehicle
    {
        private double quantity;
        private double kmPerLiter;




        public Vehicle(double quantity, double kmPerLiters)
        {
            this.Quantity = quantity;
            this.KmPerLiter = kmPerLiters;
        }

        public double KmPerLiter
        {
            get { return this.kmPerLiter; }
            set { this.kmPerLiter = value; }
        }


        public double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }


        public double Drive(double kilometers)
        {
            var total = kilometers * this.KmPerLiter;
            if (total <= Quantity)
            {
                Console.WriteLine($"{this.GetType().Name} travelled {kilometers} km");
                return this.Quantity -= total;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
                return this.Quantity;
            }
        }

        public virtual double Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return this.Quantity;
            }
            else
            {
                return this.Quantity += liters;

            }

        }

    }
}
