using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class Fanta : IDrinks
{
public string getFlavour()
{
    return "Fanta";
}

public string getDrinkType()
{
    return "Regular";
}
}