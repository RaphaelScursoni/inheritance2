using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMarket.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) 
            : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice(double price, double customsFee) 
        {
            double p = price + customsFee;
            return p;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice(Price, CustomsFee)
                + " "
                + "(Customs fee: $ "
                + CustomsFee
                + ")";
        }
    }
}
