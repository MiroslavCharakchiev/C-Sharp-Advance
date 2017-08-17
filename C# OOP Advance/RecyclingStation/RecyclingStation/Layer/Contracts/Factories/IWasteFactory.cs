using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Layer.Contracts.Factories
{
    public interface  IWasteFactory
    {
        IWaste Create(string name, double wight, double volumePerKg, string type);
    }
}