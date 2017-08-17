using System;
using System.Reflection;
using RecyclingStation.Layer.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;
using System.Linq;

namespace RecyclingStation.Layer.Factories
{
    public class WasteFactory : IWasteFactory
    {
        public IWaste Create(string name, double wight, double volumePerKg, string type)
        {
            Type typeOfGarbage = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(type + "Garbage", StringComparison.OrdinalIgnoreCase));
            object[]  typeArgs = new object[] {name, wight, volumePerKg};

            IWaste waste = (IWaste) Activator.CreateInstance(typeOfGarbage, typeArgs);
            return waste;
        }
    }
}