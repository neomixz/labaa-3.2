using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_2_ReWrite
{
    class PROPERTY_SALE : TAX
    {        
        public PROPERTY_SALE()
        {
            Name = "Property sale: ";
        }
        public override void CalculationsTaxes(int INCOME) //year income
        {
            Tax = Convert.ToInt32(Math.Round(((INCOME * _PDFO2) / 100.0) * 12.0 + ((INCOME * _Mill_T) / 100.0) * 12.0));
        }
    }
}
