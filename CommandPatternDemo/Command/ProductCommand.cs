using CommandPatternDemo.Reciever;

namespace CommandPatternDemo.Command
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;
        public bool _isCommandExecuted { get; private set; }

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void Execute()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
                _isCommandExecuted = true;
            }
            else
            {
                _isCommandExecuted = _product.DecreasePrice(_amount);                
            }
        }

        public void UnExecute()
        {
            if (!_isCommandExecuted)
                return;

            if (_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
            }
            else
            {
                _product.IncreasePrice(_amount);
            }
        }
    }
}
