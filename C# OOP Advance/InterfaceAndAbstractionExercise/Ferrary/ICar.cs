namespace Ferrary
{
    public interface ICar
    {
        string DriverName { get; }
        string Model { get; }

        void Break();
        void Gas();
    }
}
