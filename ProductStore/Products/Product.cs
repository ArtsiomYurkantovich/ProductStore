using System;
using System.Globalization;


namespace ProductStore
{
    class Product
    {
        protected string nameProduct { get; set; }
        protected double weigtProduct { get; set; }
        protected double priceProduct { get; set; }
        protected double coastProduct { get; set; }


        protected Product()
        { }

        protected Product(string name, double weight, double price)
        {
            nameProduct = name;
            weigtProduct = weight;
            priceProduct = price;
        }

        public virtual void DisplayCoast()
        {
            Console.WriteLine($"Enter please amount of {nameProduct}");
            double amountProduct;

            while (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out amountProduct))
            {
                ShowErrorMsg("Enter please correct amount of product: ");
            }

            CoastProduct(amountProduct);
        }

        protected virtual void CoastProduct(double amountProduct)
        {
            if (amountProduct > weigtProduct)
            {
                ShowErrorMsg($"There are not so many {nameProduct} in store.");
            }
            else
            {
                coastProduct = priceProduct * amountProduct;
                ShowResult($"Coast {nameProduct} per {amountProduct} kilogram  = {coastProduct} $.");
            }

        }

        public virtual void DisplayStats()
        {
            var message = $"Price per kilogram {nameProduct} = {priceProduct} $. Number of {nameProduct} in store = {weigtProduct} kg.";
            Program.ShowMessage(message);
        }

        public static void ShowErrorMsg(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var msg in msgs)
            {
                Console.WriteLine($"Error: {msg}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowResult(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var msg in msgs)
            {
                Console.WriteLine($"Error: {msg}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
