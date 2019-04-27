using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication.Controllers
{
    public class SellerController : Controller
    {
        public string Name { get; set; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Name = HttpContext.Request.Path.ToString().Trim('/').Split('/')[0];
            base.OnActionExecuting(context);
        }
    }
}