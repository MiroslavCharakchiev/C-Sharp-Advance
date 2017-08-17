namespace RecyclingStation.Layer.Contracts.Core
{
    public interface IRecyclingStattion
    {
        string ProcessGarbage(string name, double wight, double volumePerKg, string type);
        string Status();
    }
}