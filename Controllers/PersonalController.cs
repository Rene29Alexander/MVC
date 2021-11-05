using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApp.Models;

namespace firstApp.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name ="Rene";
            personal.lastname ="Araujo";
            personal.age=22;
            personal.correo ="rene29alexander@gmail.com";
            personal.telefono ="75511001";
            personal.direccion ="col el molino pasaje J1 San Miguel El Salvador";
            return View(personal);
        }
    }
}