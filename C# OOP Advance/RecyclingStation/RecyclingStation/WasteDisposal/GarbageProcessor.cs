namespace RecyclingStation.WasteDisposal
{
    using System;
    using System.Linq;
    using RecyclingStation.WasteDisposal.Attributes;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class GarbageProcessor : IGarbageProcessor
    {
        public GarbageProcessor(IStrategyHolder strategyHolder)
        {
            this.StrategyHolder = strategyHolder;
        }



        public IStrategyHolder StrategyHolder { get; private set; }

        public IProcessingData ProcessWaste(IWaste garbage)
        {
            Type type = garbage.GetType();
            DisposableAttribute disposalAttribute = (DisposableAttribute)type.GetCustomAttributes(typeof(DisposableAttribute), true).FirstOrDefault();
            if (disposalAttribute == null)
            {
                throw new ArgumentException(
                    "The passed in garbage does not implement a supported Disposable Strategy Attribute.");
            }
            Type typeOfAttribute = disposalAttribute.GetType();
            if (!this.StrategyHolder.GetDisposalStrategies.ContainsKey(typeOfAttribute))
            {
                Type typeOfcorespondongStrategy = disposalAttribute.CorespondingStrategyType;

                IGarbageDisposalStrategy avtivatedStrategy =
                    (IGarbageDisposalStrategy)Activator.CreateInstance(typeOfcorespondongStrategy);

                this.StrategyHolder.AddStrategy(typeOfAttribute, avtivatedStrategy);
            }
            IGarbageDisposalStrategy currentStrategy = this.StrategyHolder.GetDisposalStrategies[typeOfAttribute];
            return currentStrategy.ProcessGarbage(garbage);
        }
    }
}
