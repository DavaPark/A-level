namespace Models
{
    public class Apartment
    {
        public PluggedAppliance[] Appliances { get; set; }

        public Apartment(PluggedAppliance[] appliances)
        {
            Appliances = appliances;
        }
    }
}