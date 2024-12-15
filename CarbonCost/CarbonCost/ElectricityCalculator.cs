using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    // Polymorphism: Implements the abstract method for electricity emissions.
    // Inheritance: Inherits shared logic from EmissionCalculatorBase.
    public class ElectricityCalculator : EmissionCalculatorBase
    {
        private readonly IAPIServices _apiServices;
        private string _unit;
        private double _value;
        private string _country;

        public ElectricityCalculator(IAPIServices apiServices, string unit, double value, string country)
        {
            _apiServices = apiServices;
            _unit = unit;
            _value = value;
            _country = country;
        }

        public override async Task<double> CalculateEmissionsAsync()
        {
            return await _apiServices.GetElectricityEmissionsAsync(_unit, _value, _country, null);
        }
    }

}
