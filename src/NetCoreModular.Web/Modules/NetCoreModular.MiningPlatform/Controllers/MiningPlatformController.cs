using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreModular.Web.Controllers;

namespace NetCoreModular.HelloWorld.Controllers 
{
    public class MiningPlatformController : NcModularController 
    {
        public MiningPlatformController() {
        }
        public IActionResult Index () {
            return View ();
        }
        public IActionResult Test () {
            return View ();
        }
    }
}