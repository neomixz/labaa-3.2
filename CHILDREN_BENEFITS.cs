using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_2_ReWrite
{
    class CHILDREN_BENEFITS : TAX
    {
        public CHILDREN_BENEFITS()
        {
            Name = "Children benefits: ";
        }        
        public override void CalculationsTaxes(int INCOME)
        {
            Tax = Convert.ToInt32(Math.Round(((INCOME * _PDFO2) / 100.0) * 12));
        }
    }
}
