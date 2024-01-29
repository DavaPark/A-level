using Models;

namespace Services
{
    public class ElectricalApplianceService : IElectricalApplianceService
    {
        public void PlugIn(PluggedAppliance appliance)
        {
            appliance.ConnectionStatus = Enums.ConnectionStatus.Connected;
        }

        public void PlugOut(PluggedAppliance appliance)
        {
            appliance.ConnectionStatus = Enums.ConnectionStatus.Disconnected;
        }

        public double CalculateTotalPower(PluggedAppliance[] appliances)
        {
            double totalPower = 0;
            for (int i = 0; i < appliances.Length; i++)
            {
                totalPower += appliances[i].CalculatePower();
            }
            return totalPower;
        }
    }
}