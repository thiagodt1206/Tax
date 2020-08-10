using System;
using System.Collections.Generic;
using System.Text;

namespace Tax.Entities
{
    class Individual: TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }


        public override double Tax()
        {
            double taxAmount;

            if (AnualIncome <= 20000.00)
            {
                taxAmount = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                taxAmount = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }

            return taxAmount;
        }

        public override string ToString()
        {
            return String.Format($"{Name}\t{Tax():C2}");
        }
    }
}
