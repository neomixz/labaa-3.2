using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_2_ReWrite
{
    class ABROAD_TRANSFERS : TAX
    {
        public ABROAD_TRANSFERS()
        {
            Name = "Abroad tranfers: ";
        }
        public override void CalculationsTaxes(int INCOME) //year income
        {
            Tax = Convert.ToInt32(Math.Round(((INCOME * _PDFO1) / 100.0)) * 12.0);
        }
    }
}
