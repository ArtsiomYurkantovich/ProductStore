using System;

namespace ProductStore
{
    enum Choise
    {
        Apple = 1,
        Lemon,
        Orange,
        Butter,
        Kefir,
        Milk,
        Exit,

    }
    class Program
    {
        private static bool RequestedExit;
        static readonly Fruits apple = new Fruits("Apple", 20, 7);
        static readonly Fruits lemon = new Fruits("Lemon", 210, 1.5);
        static readonly Fruits orange = new Fruits("Orange", 17, 4);
        static readonly Milk butter = new Milk("Butter", 30, 2);
        static readonly Milk kefir = new Milk("Kefir", 12, 1.5);
        static readonly Milk milk = new Milk("Milk", 85, 4);

        private static void Main(string[] args)
        {

            RunApplication();
        }

        private static void RunApplication()
        {

            while (!RequestedExit)
            {
                ShowCommands();
                Console.WriteLine("Select the product you need to buy:");
                WaitForCommand();
            }
        }

        private static void WaitForCommand()
        {

            int command;

            while (!int.TryParse(Console.ReadLine(), out command))
            {
                Product.ShowErrorMsg($"Command doesn't exist\n");
            }

            choiseOperation(command);
        }


        private static void choiseOperation(int command)
        {
            switch ((Choise)command)
            {

                case Choise.Apple:
                    apple.DisplayStats();
                    apple.DisplayCoast();
                    break;

                case Choise.Lemon:

                    lemon.DisplayStats();
                    lemon.DisplayCoast();
                    break;

                case Choise.Orange:

                    orange.DisplayStats();
                    orange.DisplayCoast();
                    break;

                case Choise.Butter:

                    butter.DisplayStats();
                    butter.DisplayCoast();
                    break;

                case Choise.Kefir:

                    kefir.DisplayStats();
                    kefir.DisplayCoast();
                    break;

                case Choise.Milk:

                    milk.DisplayStats();
                    milk.DisplayCoast();
                    break;
                case Choise.Exit:
                    RequestedExit = true;
                    break;
            }
        }

        private static void ShowCommands()
        {
            ShowMessage(
                $"1) {Choise.Apple} - Apples available in the store.",
                $"2) {Choise.Lemon} - Lemons available in the store.",
                $"3) {Choise.Orange} - Oranges available in the store.",
                $"4) {Choise.Butter} - Butter available in the store.",
                $"5) {Choise.Kefir} - Kefir available in the store.",
                $"6) {Choise.Milk} - Milk available in the store.",
                $"7) {Choise.Exit} - Exit the programm.");

        }
        public static void ShowMessage(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var msg in msgs)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
