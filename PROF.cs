using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_2_ReWrite
{
    class PROF : TAX
    {
        public PROF()
        {
            Name = "Main or Second job: ";
        }
        public override void CalculationsTaxes(int INCOME)
        { 
            Tax = Convert.ToInt32(Math.Round(((INCOME * _PDFO1) / 100.0) * 12.0 + ((INCOME * _ESV) / 100.0) * 12.0 + ((INCOME * _Mill_T) / 100.0) * 12.0));
        }
    }
}
