using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_2_ReWrite
{
    class Person_TAXES
    {
        private List<TAX> taxes;


        public Person_TAXES()
        {
            taxes = new List<TAX>();
            Add_Taxes();
            Console.WriteLine($"\nYear's TAX: {Year_TAX()}$");



            taxes.Sort();

            Console.WriteLine("\n");
            foreach (var item in taxes)
            {
                Console.WriteLine(item.Name + ": " + item.Tax + "$");
            }
        }

        private void Add_Taxes()
        {
            taxes.Add(new PROF()); //основна робота
            taxes.Add(new PROF());//додатоква робота
            taxes.Add(new ROYALTIES());
            taxes.Add(new PROPERTY_SALE());
            taxes.Add(new MONEY_PROPERTY_GIFTS());
            taxes.Add(new ABROAD_TRANSFERS());
            taxes.Add(new CHILDREN_BENEFITS());
            taxes.Add(new FINANCIAL_AID());
        }
        private int Year_TAX()
        {
            int year_tax = 0;

            foreach (var item in taxes)
            {
                Console.Write(item.Name);
                item.CalculationsTaxes(int.Parse(Console.ReadLine()));
                year_tax += item.Tax;
            }


            return year_tax;
        }
    }
}
