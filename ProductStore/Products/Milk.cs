using System;

namespace ProductStore
{
    class Milk : Product
    {
        public Milk(string name, double weight, double price) : base(name, weight, price)
        {
        }
        public override void DisplayCoast()
        {
            Console.WriteLine($"Enter please amount of {nameProduct}");
            int amountProduct;
            while (!int.TryParse(Console.ReadLine(), out amountProduct))
            {
                ShowErrorMsg("Enter please correct amount of product: ");
            }
            CoastProduct(amountProduct);
        }

        public override void DisplayStats()
        {
            var message = $"Price per packing {nameProduct} = {priceProduct} $. Number of {nameProduct} in store = {weigtProduct} pieces.";

            Program.ShowMessage(message);

        }

        protected override void CoastProduct(double amountProduct)
        {
            if (amountProduct > weigtProduct)
            {
                ShowErrorMsg($"There are not so many {nameProduct} in store.");
            }
            else
            {
                coastProduct = priceProduct * amountProduct;
                ShowResult($"Coast {nameProduct} per {amountProduct} packing  = {coastProduct} $.");
            }
        }
    }
}
