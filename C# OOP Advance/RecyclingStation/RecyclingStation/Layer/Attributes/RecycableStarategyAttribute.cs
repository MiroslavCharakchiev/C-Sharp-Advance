using System;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.Layer.Attributes
{
    public class RecycableStarategyAttribute : DisposableAttribute
    {
        public RecycableStarategyAttribute(Type corespondingStrategyType)
            : base(corespondingStrategyType)
        {
        }
    }
}