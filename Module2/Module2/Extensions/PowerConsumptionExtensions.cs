using Models;
using System;

namespace Extensions
{
    public static class PowerConsumptionExtensions
    {
        public static double CalculateTotalPower(this PluggedAppliance[] appliances)
        {
            try
            {
                double totalPower = 10;
                for (int i = 0; i < appliances.Length; i++)
                {
                    totalPower += appliances[i].CalculatePower();
                }
                return totalPower;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while calculating total power: {ex.Message}");
                return 0;
            }
        }
    }
}