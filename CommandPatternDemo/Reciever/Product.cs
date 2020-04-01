using static System.Console;

namespace CommandPatternDemo.Reciever
{
    /// <summary>
    /// Reciever class
    /// </summary>
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            WriteLine($"The price for the {Name} has been increased by {amount}$.");
        }

        public bool DecreasePrice(int amount)
        {
            if (amount < Price)
            {
                Price -= amount;
                WriteLine($"The price for the {Name} has been decreased by {amount}$.");
                return true;
            }
            else
            {
                WriteLine($"Cannot decrease the amount {amount}$ from the current amount {Price}$");
                return false;
            }
        }

        public override string ToString() 
            => $"Current price for the {Name} product is {Price}$.";
    }

}

