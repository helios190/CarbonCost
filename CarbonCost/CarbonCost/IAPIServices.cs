using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    public interface IAPIServices
    {
        Task<double> GetElectricityEmissionsAsync(string unit, double value, string country, string state = null);
        Task<double> GetFuelCombustionEmissionsAsync(string fuelType, double quantity, string unit);
        Task<double> GetShippingEmissionsAsync(double weight, string weightUnit, double distance, string distanceUnit, string transportMethod);
    }
}
