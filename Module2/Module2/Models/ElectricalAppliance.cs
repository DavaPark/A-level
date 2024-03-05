using Enums;

namespace Models
{
    public class ElectricalAppliance
    {
        public string Name { get; set; }
        public double PowerConsumption { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }

        public virtual double CalculatePower()
        {
            return PowerConsumption;
        }
    }
}