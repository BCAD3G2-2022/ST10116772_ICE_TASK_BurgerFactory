using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class Coke : IDrinks
{
public string getFlavour()
{
    return "Coke";
}

public string getDrinkType()
{
    return "Diet";
}
}