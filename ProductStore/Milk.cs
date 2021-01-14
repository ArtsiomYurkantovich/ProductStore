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
            Program.ShowMessage($"Price per packing {nameProduct} = {priceProduct} $. Number of {nameProduct} in store = {weigtProduct} pieces.");

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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Coast {nameProduct} per {amountProduct} packing  = {coastProduct} $.");
                Console.ResetColor();
            }
        }

    }
}
