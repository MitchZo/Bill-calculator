

using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill
            {
                Subtotal = 15.80,
                TaxRate = 0.06
            };

            Pay(bill);

            TippableBill tippedBill = new TippableBill
            {
                Subtotal = 8.50,
                TaxRate = 0.06,
                Tip = 2.00
            };

            Pay(tippedBill);
        }
        public static void Pay(Bill bill)
        {
            Console.WriteLine($"${bill.CalcTotal().ToString()}");
        }
    }
}
