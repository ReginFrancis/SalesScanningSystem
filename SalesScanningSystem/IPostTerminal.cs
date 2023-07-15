using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesScanningSystem
{
    public interface IPostTerminal
    {
        public void SetPricing(List<PriceModel> priceModel);
        public void ScanProduct(string productCode);
        public decimal CalculateTotal();

    }
}
