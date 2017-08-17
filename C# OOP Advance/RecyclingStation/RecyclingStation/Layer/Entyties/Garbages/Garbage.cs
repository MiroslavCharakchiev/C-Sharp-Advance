using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Layer.Entyties.Garbages
{
    public abstract  class Garbage : IWaste
    {
        protected Garbage(string name, double weight, double volumePerKg)
        {
            this.Name = name;
            this.Weight = weight;
            this.VolumePerKg = volumePerKg;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double VolumePerKg { get; set; }

    }
}