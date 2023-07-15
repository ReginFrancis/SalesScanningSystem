using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SalesScanningSystem
{
    public class PostTerminal : IPostTerminal
    {

        private Dictionary<string, int> scannedProducts;
        static List<PriceModel> PriceModelData;

        public PostTerminal()
        {
            scannedProducts = new Dictionary<string, int>();
        }

        /// <summary>
        /// method to set Pricemodel
        /// </summary>
        /// <param name="priceModel"></param>
        public void SetPricing(List<PriceModel> priceModel)
        {
            try
            {
                if (priceModel == null || priceModel.Count == 0)
                {
                    PriceModelData = PriceModelList.PriceModelData;
                }
                else
                {
                    priceModel = priceModel;
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }



        /// <summary>
        /// Method to add product to scannedproducts dictionary with total item count
        /// </summary>
        /// <param name="productCode"></param>
        public void ScanProduct(string productCode)
        {
            try
            {

                for (int i = 0; i < productCode.Length; i += 2)
                {
                    string individualProductCode = productCode.Substring(i, 2);

                    if (scannedProducts.ContainsKey(individualProductCode))
                    {
                        scannedProducts[individualProductCode]++;
                    }
                    else
                    {
                        scannedProducts[individualProductCode] = 1;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    

        /// <summary>
        /// Method to calculate the total price amount
        /// </summary>
        /// <returns></returns>
        public decimal CalculateTotal()
        {
            decimal total = 0;
            try
            {
                foreach (var scannedProduct in scannedProducts)
                {
                    var PriceModel = PriceModelData?.Find(p => p.Product_Code == scannedProduct.Key);
                    if (PriceModel != null)
                    {
                        int quantity = scannedProduct.Value;
                        decimal unitPrice = PriceModel.Unit_Price;
                        int volumeQuantity = PriceModel.Item_Quantity;
                        decimal volumePrice = PriceModel.Item_Price;
                        if (volumeQuantity > 0 && quantity >= volumeQuantity)
                        {
                            int volumeSets = quantity / volumeQuantity;
                            int remainingItems = quantity % volumeQuantity;
                            total += volumeSets * volumePrice + remainingItems * unitPrice;
                        }
                        else
                        {
                            total += quantity * unitPrice;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return total;
        }
    }
}
