using RecyclingStation.Layer.Contracts.Core;
using RecyclingStation.Layer.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Layer.Core
{
    public class RecyclingStattion : IRecyclingStattion
    {
        private IGarbageProcessor garbageProcessor;
        private IWasteFactory wasteFactory;

        private double energyBalance;
        private double capitalBalance;
        private double minEnergyBalance;
        private double minCapitalBalance;

        private string typeOfGarabage;

        private bool requarementAreSet;

        public RecyclingStattion(IGarbageProcessor garbageProcessor, IWasteFactory wasteFactory)
        {
            this.garbageProcessor = garbageProcessor;
            this.wasteFactory = wasteFactory;
        }

        public string ChangeManagementRequirement(double minEnergyBalanse, double minCapitalBalance, string typeOfGarbage)
        {
            this.minEnergyBalance = minEnergyBalanse;
            this.minCapitalBalance = minCapitalBalance;
            this.typeOfGarabage = typeOfGarbage;

            this.requarementAreSet = true;
            return "Management requirement changed!";
        }
        public string ProcessGarbage(string name, double wight, double volumePerKg, string type)
        {
            if (this.requarementAreSet)
            {
                bool requarementAreSatisfied = true;
                if (this.typeOfGarabage == type)
                {
                    requarementAreSatisfied = this.capitalBalance >= this.minCapitalBalance &&
                                              this.energyBalance >= this.minEnergyBalance;
                }
                if (!requarementAreSatisfied)
                {
                    return "Processing Denied!";
                }
            }
            IWaste someWaste = this.wasteFactory.Create(name, wight, volumePerKg, type);

            IProcessingData info = this.garbageProcessor.ProcessWaste(someWaste);
            this.energyBalance += info.EnergyBalance;
            this.capitalBalance += info.CapitalBalance;
            return $"{someWaste.Weight:f2} kg of {someWaste.Name} successfully processed!";
        }

        public string Status()
        {

            return $"Energy: {this.energyBalance:f2} Capital: {this.capitalBalance:f2}";
        }
    }
}