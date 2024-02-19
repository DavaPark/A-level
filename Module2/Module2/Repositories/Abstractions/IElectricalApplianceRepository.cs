using Models;

namespace Repositories
{
    public interface IElectricalApplianceRepository
    {
        PluggedAppliance[] GetAppliances();
    }
}