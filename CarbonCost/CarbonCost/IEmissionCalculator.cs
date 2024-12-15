using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    // Polymorphism
    internal interface IEmissionCalculator
    {
        Task<double> CalculateEmissionsAsync();
    }
}
