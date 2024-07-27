

namespace Solidlmp.OCP
{
    public abstract class ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public abstract decimal CalculateTaxAmount();        
    }
}
