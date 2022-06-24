using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_2_ReWrite
{
    class FINANCIAL_AID : TAX
    { 
        public FINANCIAL_AID()
        {
            Name = "Financial aid: ";
        }
        public override void CalculationsTaxes(int INCOME)
        {
            Tax = Convert.ToInt32(Math.Round(((INCOME * _PDFO2) / 100.0) * 12));
        }
    }
}
