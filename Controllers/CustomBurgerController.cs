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
    
public class CustomBurgerController : ControllerBase
{

[HttpGet]
public List<string> Get(bool tomato, bool cheese, bool bun, bool patty, bool lettuce)
{
    IComponet burgerBun = new Bun();
    IComponet burgerPatty = new Patty();
    IComponet burgerLettuce = new Lettuce();
    IComponet burgerTomato = new Tomato();
    IComponet burgerCheese = new Cheese();
    
    Composite BaseBurger = new Composite();
    BaseBurger.addPart(burgerBun);
    BaseBurger.addPart(burgerPatty);
    BaseBurger.addPart(burgerLettuce);
    BaseBurger.addPart(burgerCheese);
    BaseBurger.addPart(burgerTomato);

    if(!tomato)
    {
        BaseBurger.removePart(burgerTomato);
    }
    if(!lettuce)
    {
        BaseBurger.removePart(burgerLettuce);
    }
    if(!cheese)
    {
        BaseBurger.removePart(burgerCheese);
    }
    if(!bun)
    {
        BaseBurger.removePart(burgerBun);
    }
    if(!patty)
    {
        BaseBurger.removePart(burgerPatty);
    }

    List<string> returnList = new List<string>();
    returnList.Add(BaseBurger.getPart());

 return returnList;
}
}

}

