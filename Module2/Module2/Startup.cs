using Services;
using Extensions;
using Repositories;
using SimpleInjector;
using Models;

public class Startup
{
    private static Container container;

    static Startup()
    {
        container = new Container();
        container.Register<IElectricalApplianceRepository, ElectricalApplianceRepository>();
        container.Register<IElectricalApplianceService, ElectricalApplianceService>();
    }

    public static void App()
    {
        try
        {
            PluggedAppliance[] appliances = container.GetInstance<IElectricalApplianceRepository>().GetAppliances();

            for (int i = 0; i < appliances.Length; i++)
            {
                container.GetInstance<IElectricalApplianceService>().PlugIn(appliances[i]);
            }

            Console.WriteLine($"Total power consumption in the apartment: {appliances.CalculateTotalPower()} watts");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}