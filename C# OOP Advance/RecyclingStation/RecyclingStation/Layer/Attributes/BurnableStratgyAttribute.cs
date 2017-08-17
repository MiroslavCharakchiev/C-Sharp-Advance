using System;
using System.Runtime.CompilerServices;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.Layer.Attributes
{
    public class BurnableStratgyAttribute : DisposableAttribute
    {
        public BurnableStratgyAttribute(Type corespondingStrategyType) 
            : base(corespondingStrategyType)
        {
        }
    }
}