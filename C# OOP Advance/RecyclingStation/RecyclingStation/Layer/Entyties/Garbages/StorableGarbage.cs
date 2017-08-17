using RecyclingStation.Layer.Attributes;
using RecyclingStation.Layer.Strategy;

namespace RecyclingStation.Layer.Entyties.Garbages
{
    [StorableStrategy(typeof(StoragbeGarbageDisposalStrategy))]
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
        }
    }
}