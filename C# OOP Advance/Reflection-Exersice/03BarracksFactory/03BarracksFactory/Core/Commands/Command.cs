using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository reposytory;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository reposytory, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Reposytory = reposytory;
            this.UnitFactory = unitFactory;
        }

        protected string[] Data
        {
            get { return this.data; }
            private set { this.data = value; }
        }

        protected IRepository Reposytory
        {
            get { return this.reposytory; }
            private set { this.reposytory = value; }
        }

        protected IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }
            private set { this.unitFactory = value; }
        }

        public abstract string Execute();

    }
}