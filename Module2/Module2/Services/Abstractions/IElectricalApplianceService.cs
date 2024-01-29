using Models;

namespace Services
{
    public interface IElectricalApplianceService
    {
        void PlugIn(PluggedAppliance appliance);
        void PlugOut(PluggedAppliance appliance);
        double CalculateTotalPower(PluggedAppliance[] appliances);
    }
}