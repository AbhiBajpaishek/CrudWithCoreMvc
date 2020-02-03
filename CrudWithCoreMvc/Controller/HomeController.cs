using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CrudWithCoreMvc.Controller
{
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "Hello World from Index View";
        }
    }
}
