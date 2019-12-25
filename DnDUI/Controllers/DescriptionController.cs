using Core.Library.Characteristics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDUI.Controllers
{
    public class DescriptionController : Controller
    {
        [HttpGet]
        public IActionResult Description()
        {
            //displays character's description
            return View();
        }
        [HttpPost]
        public IActionResult Description(Guid characterId, Description description)
        {
            //save the description of the character
            return View();
        }
    }
}
