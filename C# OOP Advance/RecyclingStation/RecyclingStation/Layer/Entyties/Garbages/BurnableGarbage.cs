using RecyclingStation.Layer.Attributes;
using RecyclingStation.Layer.Strategy;

namespace RecyclingStation.Layer.Entyties.Garbages
{
    [BurnableStratgy(typeof(BurnableGarbageDisposalStrategy))]
    public class BurnableGarbage : Garbage
    {
        public BurnableGarbage(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
        }
    }
}