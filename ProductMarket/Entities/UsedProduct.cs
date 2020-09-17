﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMarket.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct () { }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (Used)"
                + " $ "
                + Price
                + " (Manufacture date: "
                + ManufactureDate
                + ")";
        }
    }
}
