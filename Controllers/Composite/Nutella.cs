using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
    public class Nutella : IIceCreamComponet
    {
        public string getIceCreamFlavour()
        {
            return "Nutella";
        }
    }
}