using System;
using System.Collections.Generic;
using System.Text;

namespace Tax.Entities
{
    class Company:TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxAmount;
            if (NumberOfEmployees >= 10)
            {
                taxAmount = AnualIncome * 0.14;
            }
            else
            {
                taxAmount = AnualIncome * 0.16;
            }
            return taxAmount;
        }

        public override string ToString()
        {
            return String.Format($"{Name}\t{Tax():C2}");
        }

    }
}
