using System;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.Layer.Attributes
{
    public class StorableStrategyAttribute : DisposableAttribute
    {
        public StorableStrategyAttribute(Type corespondingStrategyType) 
            : base(corespondingStrategyType)
        {
        }
    }
}