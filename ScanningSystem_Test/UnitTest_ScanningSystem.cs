using SalesScanningSystem;

namespace ScanningSystem_Test
{
    [TestFixture]
    public class Tests
    {
        private IPostTerminal postTerminal;
            
        [SetUp]
        public void Setup()
        {
            postTerminal = new PostTerminal();
        }



        /// <summary>
        /// test case to check the output of total price
        /// </summary>
        [Test]
        public void Test1()
        {
            List<PriceModel> PriceModelData = new List<PriceModel>
            {
                new PriceModel { Product_Code = "A1", Unit_Price = 1.30m, Item_Quantity = 3, Item_Price = 3.00m },
                new PriceModel { Product_Code = "A2", Unit_Price = 4.30m },
                new PriceModel { Product_Code = "A3", Unit_Price = 1m, Item_Quantity = 6, Item_Price = 5.00m },
                new PriceModel { Product_Code = "A4", Unit_Price = 2.50m }
            };
            postTerminal.SetPricing(PriceModelData);

            postTerminal.ScanProduct("A3");
            postTerminal.ScanProduct("A3");
            postTerminal.ScanProduct("A3");
            postTerminal.ScanProduct("A3");
            postTerminal.ScanProduct("A3");
            postTerminal.ScanProduct("A3");
            postTerminal.ScanProduct("A3");

            decimal actualResult = postTerminal.CalculateTotal();
            decimal expectedResult = 6.0m;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}