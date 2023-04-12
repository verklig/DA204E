using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// This class is an enum of the different categories of food that the user can choose when making a recipe.
    /// It is passed to the other classes that need it for the program to function properly, and it's printed
    /// on a drop down list on the programs gui.
    /// </summary>
    public enum FoodCategory
    {
        Meat,
        Pasta,
        Pizza,
        Fish,
        Seafood,
        Soup,
        Stew,
        Vegan,
        Vegetarian,
        Other
    }
}
