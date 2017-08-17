namespace RecyclingStation.WasteDisposal.Interfaces
{
    public static class HelperMethods
    {
        public static double CalculateTotalVol(double weight, double volumePerKg)
        {
            return weight * volumePerKg;
        }
    }
}