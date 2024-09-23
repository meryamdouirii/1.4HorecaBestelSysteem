using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum ItemType
    {
        //Starter=voorgerecht, Main=hoofdgerecht, Dessert=nagerecht, Intermediate=tussengerecht
        //Starter = 1, Main = 2, Dessert = 3, SoftDrinks = 4, Beer = 5, Wine = 6, Alcoholic = 7, TeaAndCoffee = 8, Intermediate = 9, unknown
        Starter = 1, Main = 2, Dessert = 3, SoftDrinks = 4, Beer = 5, Wine = 6, Spirits = 7, TeaAndCoffee = 8, Intermediate = 9, unknown
    }
}
