using System;
using calc.Sortes;

namespace calc.Factories
{
    public static class ArraySortesFactory
    {
        public static ISort CreateSort(string sortName)
        {
            switch (sortName)
            {
                case "Bubble":
                    return new BubbleSort();

                case "Cocktail":
                    return new CocktailSort();

                case "Gnome":
                    return new GnomeSort();

                case "Selection":
                    return new SelectionSort();

                default:
                    throw new Exception("Unknown sort");
            }
        }  
    }
}