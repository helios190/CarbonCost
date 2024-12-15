using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    // Polymorphism: Implements the abstract method for fuel combustion emissions.
    // Inheritance: Inherits shared logic from EmissionCalculatorBase.
    public class FuelCalculator : EmissionCalculatorBase
    {
        private readonly APIServices _apiServices;
        private double _quantity;
        private string _fuelType;
        private string _unit;

        public FuelCalculator(APIServices apiServices, string fuelType, double quantity, string unit)
        {
            _apiServices = apiServices;
            _fuelType = fuelType;
            _quantity = quantity;
            _unit = unit;
        }

        public override async Task<double> CalculateEmissionsAsync()
        {
            return await _apiServices.GetFuelCombustionEmissionsAsync(_fuelType, _quantity, _unit);
        }
    }

}
