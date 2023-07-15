using SalesScanningSystem;
using System.Collections.Generic;
using System.Windows;

namespace StoreScanningSystem_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string combinedProductCode = string.Empty;
        static List<ProductList> items = new List<ProductList>();
        public MainWindow()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Add to cart button click and functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cart_Click(object sender, RoutedEventArgs e)
        {
            combinedProductCode = combinedProductCode + txt_productCode.Text?.ToUpper();

            var matchedProduct = PriceModelList.PriceModelData.Find(x => x.Product_Code.ToLower() == txt_productCode.Text.ToString().ToLower());
            if (matchedProduct != null)
            {
                decimal unitPrice = matchedProduct.Unit_Price;
                items.Add(new ProductList() { Product_Code = txt_productCode.Text.ToUpper(), Unit_Price = unitPrice });
                MessageBox.Show("Product has been added.");
            }
            else { MessageBox.Show("Product code not matched, call for assistance."); }
            if (items != null && items.Count > 0)
            {
                gridProductList.Visibility = Visibility.Visible;
                ProductList.ItemsSource = new List<ProductList>();
                ProductList.ItemsSource = items;
                txt_productCode.Text = "";
            }
           
        }

      

        /// <summary>
        /// button "add new customer" functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_newCustomer_Click(object sender, RoutedEventArgs e)
        {
            gridProductList.Visibility = Visibility.Hidden;
            txt_productCode.Text = "";
            items = new List<ProductList>();
            ProductList.ItemsSource = new List<ProductList>();
            ProductList.ItemsSource = items;
            txt_totalPrice.Text = string.Empty;
            txt_totalPrice.Visibility = Visibility.Hidden;
            combinedProductCode = string.Empty;

        }

        /// <summary>
        /// method which invoke on button check out click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_checkout_Click(object sender, RoutedEventArgs e)
        {
            List<PriceModel> PriceModelData = new List<PriceModel>();
            var posTerminal = new PostTerminal();
            posTerminal.ScanProduct(combinedProductCode);
            posTerminal.SetPricing(PriceModelData);
            // Calculate total price
            decimal result = posTerminal.CalculateTotal();
            if (result > 0)
            {
                txt_totalPrice.Visibility = Visibility.Visible;
                txt_totalPrice.Text = "Total Price : " + result.ToString() + " £";
                MessageBox.Show("Total price is " + result);
            }
            else { MessageBox.Show("Please add items / call for assistance"); }
        }
    }
}
