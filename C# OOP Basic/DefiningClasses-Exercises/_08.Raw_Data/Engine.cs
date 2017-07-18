using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public int EnginePower
        {
            get
            {
                return this.enginePower;
            }
            set
            {
                this.enginePower = value;
            }
        }

        public Engine(int first, int second)
        {
            this.engineSpeed = first;
            this.EnginePower = second;
        }
    }
}
