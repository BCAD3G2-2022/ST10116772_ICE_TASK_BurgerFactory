using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI{
    
public class DrinksFactory 
{
    public IDrinks returnInstance;

    public IDrinks getDrink(String DrinkFlavour)
    {
       switch(DrinkFlavour)
       {
           case("coke"):
           returnInstance = new Coke();
           break;
           case("fanta"):
           returnInstance = new Fanta();
            break;
       }
        return returnInstance;
    }
}
}