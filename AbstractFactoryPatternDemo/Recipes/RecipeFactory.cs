using AbstractFactoryPatternDemo.Dessert;
using AbstractFactoryPatternDemo.MainCourse;

namespace AbstractFactoryPatternDemo.Recipes
{
    /// <summary>
    /// The AbstractFactory interface, which defines methods for creating abstract objects.
    /// </summary>
    interface RecipeFactory
    {
        ISandwich CreateSandwich();
        IDessert CreateDessert();
    }
}
