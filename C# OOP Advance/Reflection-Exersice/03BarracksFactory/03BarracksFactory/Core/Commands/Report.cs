using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class Report : Command
    {
        public Report(string[] data, IRepository reposytory, IUnitFactory unitFactory) : base(data, reposytory, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = base.Reposytory.Statistics;
            return output;
        }
    }
}