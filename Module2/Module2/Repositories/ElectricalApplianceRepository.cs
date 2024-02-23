using Models;

namespace Repositories
{
    public class ElectricalApplianceRepository : IElectricalApplianceRepository
    {
        public PluggedAppliance[] GetAppliances()
        {
            
            return new PluggedAppliance[] { };
        }
    }
}