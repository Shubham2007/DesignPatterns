using AbstractFactoryPatternDemo.Dessert;
using AbstractFactoryPatternDemo.MainCourse;

namespace AbstractFactoryPatternDemo.Recipes
{
    /// <summary>
    /// A ConcreteFactory which creates concrete objects by implementing the interface factory's methods.
    /// </summary>
    class AdultCuisineFactory : RecipeFactory
    {
        public IDessert CreateDessert()
            => new CremeBrulee();

        public ISandwich CreateSandwich()
            => new LambSandwich();
    }
}
