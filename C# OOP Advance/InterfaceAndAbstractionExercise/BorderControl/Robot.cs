namespace BorderControl
{
    public class Robot : IPopilation
    {
        public Robot( string model, string id)
        {
            this.Id = id;
            this.Model = model;
        }
        public string Id { get; }

        public string Model { get; }
    }
}
