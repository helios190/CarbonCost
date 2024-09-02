using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    public class Transaction
    {
        // Properties
        public Guid TransactionID { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public double Amount { get; private set; }
        public double Rate { get; private set; } = 15.0; // Fixed rate of 15 USD

        // Constructor
        public Transaction(double amount)
        {
            TransactionID = Guid.NewGuid();
            TransactionDate = DateTime.Now;
            Amount = amount;
        }

        // Method to execute the buy and sell of carbon credits
        public void Execute(Company buyer, Company seller)
        {
            if (Verify(buyer, seller))
            {
                buyer.CarbonCap -= Amount;
                seller.CarbonCap += Amount;
                Console.WriteLine("Transaction executed successfully.");
            }
            else
            {
                Console.WriteLine("Transaction failed. Insufficient carbon credits.");
            }
        }

        // Method to verify if the amount of carbon is sufficient for the transaction
        private bool Verify(Company buyer, Company seller)
        {
            return buyer.CarbonCap >= Amount;
        }
    }

    public class Company
    {
        public double CarbonCap { get; set; }
    }
}
