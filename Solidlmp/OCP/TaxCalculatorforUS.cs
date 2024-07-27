﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidlmp.OCP
{
    public class TaxCalculatorforUS : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public override decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 40 / 100;
        }
    }
}
