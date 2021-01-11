using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlsAndRoutes2.Models;

namespace UrlsAndRoutes2.Controllers
{
    [Route("app/[controller]/actions/[action]/{id:weekday?}")]
    public class CustomerController : Controller
    {
        public IActionResult Index() => View(nameof(Result), new Result { Controller = nameof(CustomerController), Action = nameof(Index) });
        public IActionResult List(string id)
        {
            Result result = new Result { Controller = nameof(HomeController), Action = nameof(List) };
            result.Data["id"] = id ?? "<не задано>";
            result.Data["catchall"] = RouteData.Values["catchall"];
            return View(nameof(Result), result);
        }
    }
}
