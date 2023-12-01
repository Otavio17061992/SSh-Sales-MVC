using Microsoft.AspNetCore.Mvc;

using SalesMVCCore.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMVCCore.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departments> list = new List<Departments>();

            list.Add(new Departments { ID = 1, Name = "Eletronics" });
            list.Add(new Departments { ID = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
