using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Layer.Data
{
    public class ProcesingData : IProcessingData
    {
        public ProcesingData(double energyBalance, double capitalBalance)
        {
            this.EnergyBalance = energyBalance;
            this.CapitalBalance = capitalBalance;
        }

        public double EnergyBalance { get; private set; }
        public double CapitalBalance { get; private set; }
    }
}