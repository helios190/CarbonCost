using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    // Polymorphism: Implements the abstract method for shipping emissions.
    // Inheritance: Inherits shared logic from EmissionCalculatorBase.
    public class ShippingCalculator : EmissionCalculatorBase
    {
        private readonly APIServices _apiServices;
        private double _weight;
        private double _distance;
        private string _transport;
        private string _weightUnit;
        private string _distanceUnit;

        public ShippingCalculator(APIServices apiServices, double weight, double distance, string transport, string weightUnit, string distanceUnit)
        {
            _apiServices = apiServices;
            _weight = weight;
            _distance = distance;
            _transport = transport;
            _weightUnit = weightUnit;
            _distanceUnit = distanceUnit;
        }

        public override async Task<double> CalculateEmissionsAsync()
        {
            return await _apiServices.GetShippingEmissionsAsync(_weight, _weightUnit, _distance, _distanceUnit, _transport);
        }
    }

}
