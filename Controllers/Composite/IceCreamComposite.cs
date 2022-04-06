using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
public class IceCreamComposite : IIceCreamComponet
{
    
List<IIceCreamComponet> components = new List<IIceCreamComponet>();

public void addTopping(IIceCreamComponet componet)
{
    components.Add(componet);
}

public void removeTopping(IIceCreamComponet componet)
{
    components.Remove(componet);
}

public string getIceCreamFlavour()
{
    string part = null;

 for (int i = 0; i <components.Count; i++)
 {
    part += components.ElementAt(i).getIceCreamFlavour(); 
 }
 return part;
}
}
}