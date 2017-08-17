using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Layer.Strategy
{
    public class RecycableGarbageDisposableStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste garbage)
        {
            return 0 - HelperMethods.CalculateTotalVol(garbage.Weight, garbage.VolumePerKg) * 0.5;
        }
        protected override double CalculateCapitalBalance(IWaste garbage)
        {
            return (400 * garbage.Weight) - 0;
        }
    }
}