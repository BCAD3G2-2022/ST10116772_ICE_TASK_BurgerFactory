using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
    public class Oreos : IIceCreamComponet
    {
        public string getIceCreamFlavour()
        {
            return "Oreos";
        }
    }
}