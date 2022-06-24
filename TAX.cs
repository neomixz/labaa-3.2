using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_2_ReWrite
{
    class TAX : IComparable<TAX>
    {
        private protected int _ESV = 22; //єдини соціальний податок
        private protected int _PDFO1 = 18; //податок на доходи
        private protected int _Mill_T = 2; //військовий збір
        private protected int _PDFO2 = 5;

        public int Tax { get; set; }
        public string Name { get; set; }

        public virtual void CalculationsTaxes(int INCOME) { }
        public int CompareTo(TAX other)
        {
            return Tax.CompareTo(other.Tax);
        }
    }
}
