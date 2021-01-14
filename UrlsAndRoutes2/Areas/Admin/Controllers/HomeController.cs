using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlsAndRoutes2.Areas.Admin.Models;

namespace UrlsAndRoutes2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private Person[] data = new Person[]
        {
            new Person { Name = "Алиса", City = "Деревня" },
            new Person { Name = "Вася", City = "Посёлок" },
            new Person { Name = "Уебан", City = "мАсква" }
        };

        public ViewResult Index() => View(data);
    }
}
