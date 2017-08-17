using System;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class Fight : Command
    {
        public Fight(string[] data, IRepository reposytory, IUnitFactory unitFactory) : base(data, reposytory, unitFactory)
        {
        }

        public override string Execute()
        {
           Environment.Exit(0);
            return String.Empty;
        }
    }
}