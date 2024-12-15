using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    // Inheritance: This is the base class that will be inherited by specific calculators.
    // Abstraction: It hides the validation logic and provides an abstract method.
    public abstract class EmissionCalculatorBase : IEmissionCalculator
    {
        // Encapsulation: This method is hidden from external access and ensures clean validation logic.
        protected bool ValidateInput(string input, out double value)
        {
            value = 0;
            return !string.IsNullOrWhiteSpace(input) && double.TryParse(input, out value) && value > 0;
        }

        // Polymorphism: The method is abstract and must be implemented by derived classes.
        public abstract Task<double> CalculateEmissionsAsync();
    }

}
