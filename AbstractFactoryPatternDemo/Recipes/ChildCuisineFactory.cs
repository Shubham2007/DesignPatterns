using AbstractFactoryPatternDemo.Dessert;
using AbstractFactoryPatternDemo.MainCourse;

namespace AbstractFactoryPatternDemo.Recipes
{
    /// <summary>
    /// A concrete factory which creates concrete objects by implementing the interface factory's methods.
    /// </summary>
    class ChildCuisineFactory : RecipeFactory
    {
        public IDessert CreateDessert()
            => new IceCream();

        public ISandwich CreateSandwich()
            => new EggSandwich();
    }
}
