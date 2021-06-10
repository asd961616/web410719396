using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web410719396.viewmodels;

namespace web410719396.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(model: new Signupdata());
        }

        [HttpPost]
        public ActionResult SignUp(Signupdata data)
        {

            if (ModelState.IsValid) 
            {
                data.Message = "註冊成功";
            }


            return View(data);
        }
    }
}