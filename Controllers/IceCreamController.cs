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
    
public class IceCreamController : ControllerBase
{

[HttpGet]
public List<string> Get(bool oreos, bool tex, bool crunchie, bool nutella, bool barOne)
{
    IIceCreamComponet FlavourOreo = new Oreos();
    IIceCreamComponet FlavourTex = new Tex();
    IIceCreamComponet FlavourCrunchie = new Crunchie();
    IIceCreamComponet FlavourNutella = new Nutella();
    IIceCreamComponet FlavourBarOne = new BarOne();
    
    IceCreamComposite BaseIceCream = new IceCreamComposite();
    BaseIceCream.addTopping(FlavourOreo);
    BaseIceCream.addTopping(FlavourTex);
    BaseIceCream.addTopping(FlavourCrunchie);
    BaseIceCream.addTopping(FlavourNutella);
    BaseIceCream.addTopping(FlavourBarOne);

    if(!oreos)
    {
        BaseIceCream.removeTopping(FlavourOreo);
    }
    if(!tex)
    {
        BaseIceCream.removeTopping(FlavourTex);
    }
    if(!crunchie)
    {
        BaseIceCream.removeTopping(FlavourCrunchie);
    }
    if(!nutella)
    {
        BaseIceCream.removeTopping(FlavourNutella);
    }
    if(!barOne)
    {
        BaseIceCream.removeTopping(FlavourBarOne);
    }
    

    List<string> returnList = new List<string>();
    returnList.Add(BaseIceCream.getIceCreamFlavour());

 return returnList;
}
}

}

