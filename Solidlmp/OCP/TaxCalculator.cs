

using System.Reflection.Metadata.Ecma335;

namespace Solidlmp.OCP
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryTaxCalculator obj)
        {
            decimal taxAmount = 0;
            taxAmount = obj.CalculateTaxAmount();
            return taxAmount;
        }
    }
}
