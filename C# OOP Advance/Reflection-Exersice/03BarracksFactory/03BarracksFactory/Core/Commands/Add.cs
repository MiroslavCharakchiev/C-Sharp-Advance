using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class Add : Command
    {
        public Add(string[] data, IRepository reposytory, IUnitFactory unitFactory) : base(data, reposytory, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Reposytory.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}