using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinksController : ControllerBase
    {
     public string Type;

        [HttpGet]
        public List<Drinks> Get(string drinkFlavour = "Coke")
        {
          DrinksFactory drinksFactory = new DrinksFactory();
          IDrinks drink = drinksFactory.getDrink(drinkFlavour);
          List<Drinks> returnedDrink = new List<Drinks>();
          returnedDrink.Add(new Drinks{Flavour = drink.getFlavour(),
          DrinkType = drink.getDrinkType()});
          
          return returnedDrink;
        }
    }
}
