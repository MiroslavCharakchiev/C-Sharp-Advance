using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Layer.Strategy
{
    public class StoragbeGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste garbage)
        {
            var totalVol = HelperMethods.CalculateTotalVol(garbage.Weight, garbage.VolumePerKg);
            return 0 - totalVol * 0.13;
        }

        protected override double CalculateCapitalBalance(IWaste garbage)
        {
            var totalVol = HelperMethods.CalculateTotalVol(garbage.Weight, garbage.VolumePerKg);
            return 0 - totalVol * 0.65;
        }
    }
}