using Enums;

namespace Models
{
    public class PluggedAppliance : ElectricalAppliance
    {
        public PluggedAppliance(string name, double powerConsumption) : base()
        {
            Name = name;
            PowerConsumption = powerConsumption;
            ConnectionStatus = ConnectionStatus.Disconnected;
        }

        public override double CalculatePower()
        {
            if (ConnectionStatus == ConnectionStatus.Connected)
                return PowerConsumption;
            else
                return 0;
        }
    }
}