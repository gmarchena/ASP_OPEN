using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeowWorld2.Controllers
{
    public class CatController
    {
        [HttpGet("feline/bill")]
        public string Meow()
        {
           return "Meow!";
        }
    }
}
