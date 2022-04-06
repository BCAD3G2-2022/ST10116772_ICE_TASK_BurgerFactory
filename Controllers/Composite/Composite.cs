using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
public class Composite : IComponet
{
    
List<IComponet> components = new List<IComponet>();

public void addPart(IComponet componet)
{
    components.Add(componet);
}

public void removePart(IComponet componet)
{
    components.Remove(componet);
}

public string getPart()
{
    string part = null;

 for (int i = 0; i <components.Count; i++)
 {
    part += components.ElementAt(i).getPart(); 
 }
 return part;
}
}
}