using RecyclingStation.Layer.Attributes;
using RecyclingStation.Layer.Strategy;

namespace RecyclingStation.Layer.Entyties.Garbages
{
    [RecycableStarategy(typeof(RecycableGarbageDisposableStrategy))]
    public class RecyclableGarbage : Garbage
    {
        public RecyclableGarbage(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
        }
    }
}
