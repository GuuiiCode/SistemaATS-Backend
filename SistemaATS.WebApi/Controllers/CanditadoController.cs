using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaATS.WebApi.Controllers
{
    public class CanditadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
