using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    class TippableBill : Bill
    {
        public double Tip { get; set; }

        public TippableBill()
        {

        }
        public TippableBill(double subTotal, double taxRate,double tip)
            :base(subTotal,taxRate)
        {
            Subtotal = subTotal;
            TaxRate = taxRate;
            Tip = tip;
        }
        public override double CalcTotal()
        {
            return (Subtotal * (1 + TaxRate)) + Tip;
        }
    }
}
