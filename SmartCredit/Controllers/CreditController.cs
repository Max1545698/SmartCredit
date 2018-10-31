using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartCredit.Controllers
{
    public class CreditController : Controller
    {
        public ViewResult Main()
        {
            return View();
        }
    }
}