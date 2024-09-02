using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost {
    public class CarbonCreditCapCalculator
    {
        private double energyConsumption;
        private double transportationHabits;
        private double productionMetrics;


        public double EnergyConsumption
        {
            get { return energyConsumption; }
            set { energyConsumption = value; }
        }

        public double TransportationHabits
        {
            get { return transportationHabits; }
            set { transportationHabits = value; }
        }

        public double ProductionMetrics
        {
            get { return productionMetrics; }
            set { productionMetrics = value; }
        }

        public double CalculationCap()
        {
            double cap = 0.0;

            cap = (energyConsumption + transportationHabits + ProductionMetrics) / 3;
            return cap;
        }

    }
}