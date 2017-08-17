using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Layer.Strategy
{
    public class BurnableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste garbage)
        {
            var totalVol = HelperMethods.CalculateTotalVol(garbage.Weight, garbage.VolumePerKg);
            return totalVol - (totalVol * 0.2);
        }

        protected override double CalculateCapitalBalance(IWaste garbage)
        {
            return 0;
        }
    }
}