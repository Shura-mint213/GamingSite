using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingSite.Controllers
{
    public class AuthorizationController : Controller
    {
        [Route("Authorization")]
        [HttpGet]
        public ViewResult Authorization()
        {
            return View();
        }

        [HttpPost]
        public IAsyncResult UserVerification()
        {

        }
    }
}
