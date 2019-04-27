using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication.Controllers
{
    public class BaseController : Controller
    {
        public string Name { get; set; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewData["Name"] = "BaseName";
            Name = "name";
            base.OnActionExecuting(context);
        }
    }
}