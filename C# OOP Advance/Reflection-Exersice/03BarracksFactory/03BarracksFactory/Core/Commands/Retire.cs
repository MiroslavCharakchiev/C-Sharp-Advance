using System;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class Retire : Command
    {
        public Retire(string[] data, IRepository reposytory, IUnitFactory unitFactory) : base(data, reposytory, unitFactory)
        {
        }

        public override string Execute()
        {
            var unitType = this.Data[1];
            try
            {
                this.Reposytory.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (Exception ae)
            {
                return ae.Message;
                
            }
        }
    }
}