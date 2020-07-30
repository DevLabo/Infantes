using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infantes.Application;
using Microsoft.AspNetCore.Mvc;

namespace Infantes.Web.Controllers
{
    public class InfantController : Controller
    {
        private readonly IInfantService _infantService;
         
        public InfantController(IInfantService infantService)
        {
            _infantService = infantService;
        }

        public IActionResult Index()
        {
            var infants = _infantService.GetAllInfant();

            return View(infants);
        }
    }
}
