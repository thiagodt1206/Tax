using System;
using System.Collections.Generic;
using Tax.Entities;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual of company (i/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExp));
                }
                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberEmployee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAX PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer);
            }
            double sum = 0.0;
            foreach (TaxPayer tax in list)
            {
                sum += tax.Tax();
            }

            Console.WriteLine($"TOTAL TAXES: {sum:c2}");


        }
    }
}
