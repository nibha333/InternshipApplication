using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace InternshipApplication.Controllers
{
    [Authorize]
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("~/Form/ApplicationForm");
        }
        public ActionResult ApplicationForm()
        {
            return View();
        }
    }
}