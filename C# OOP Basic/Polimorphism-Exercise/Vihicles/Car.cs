using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vihicles
{
   public class Car : Vehicle
   {
       private const double adition = 0.9;
       private  double tank;

       public Car(double quantity, double kmPerLiters, double tank) : base(quantity, kmPerLiters)
       {
           this.KmPerLiter = kmPerLiters;
           this.tank = tank;
       }

       public double KmPerLiter
       {
           get { return base.KmPerLiter; }
            set { base.KmPerLiter += adition; }
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
               return base.Refuel(liters);
           }
        }

       public override string ToString()
       {
           return $"Car: {this.Quantity:f2}";
       }
   }
}
