using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard.Mvc;
using Orchard.Security;
using Orchard.Themes;

namespace Baker.AccessToJustice.Controllers
{
    [HandleError, Themed]
    public class AccountController : Controller
    {
        [AlwaysAccessible]
        public ActionResult RegisterClient() {
            return new ShapeResult(this, null);
        }

        [HttpPost]
        [AlwaysAccessible]
        [ValidateInput(false)]
        public ActionResult RegisterClient(string userName, string email, string password, string confirmPassword) {
            return new ShapeResult(this, null);
        }
        
        [AlwaysAccessible]
        public ActionResult RegisterAttorney() {
            return new ShapeResult(this, null);
        }

        [HttpPost]
        [AlwaysAccessible]
        [ValidateInput(false)]
        public ActionResult RegisterAttorney(string userName, string email, string password, string confirmPassword) {
            return new ShapeResult(this, null);
        }
    }
}
