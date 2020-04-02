using CommandPatternDemo.Command;
using CommandPatternDemo.Invoker;
using CommandPatternDemo.Reciever;
using Common;
using System.Threading;
using static System.Console;

namespace CommandPatternDemo
{
    public class InitiateCommandPattern : IInitiatePattern
    {
        public void Initiate()
        {
            var modifyPrice = new ModifyPrice(); // Invoker
            var product = new Product("Phone", 500); // Reciever
            WriteLine("Starting price for the Phone product is 500$.");

            // Commands
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Decrease, 800));
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Decrease, 25));

            WriteLine(product);
            WriteLine();

            WriteLine("Undoing The Changes.....");
            Thread.Sleep(2000);

            // Introducing the undo action using command pattern
            modifyPrice.UndoActions();
            WriteLine(product);
        }

        /// <summary>
        /// Execute Commands by Invoker
        /// </summary>
        /// <param name="modifyPrice"></param>
        /// <param name="productCommand"></param>
        private static void Execute(ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
