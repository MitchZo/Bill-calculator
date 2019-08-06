using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill()
        {

        }
        public Bill(double subTotal, double taxRate)
        {
            Subtotal = subTotal;
            TaxRate = taxRate;
        }
        public virtual double CalcTotal()
        {
            return Subtotal * (1 + TaxRate);
        }
    }
}
