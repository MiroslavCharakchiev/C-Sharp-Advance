using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    class Tires
    {
        private int tiresAge;
        private double tiresPressure;

        public double TiresPressure
        {
            get
            {
                return this.tiresPressure;
            }
            set
            {
                this.tiresPressure = value;
            }
        }

        public Tires(int age, double pressure)
        {
            this.tiresAge = age;
            this.TiresPressure = pressure;
        }
    }
}
