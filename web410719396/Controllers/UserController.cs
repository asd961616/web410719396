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
            return View(model:new signupdata());
        }

        [HttpPost]
        public ActionResult SignUp(signupdata data)
        {
            if (data.Name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (data.Account.IsNullOrWhiteSpace())
            {
                ViewBag.AccountMessage = "請輸入帳號";
            }
            if (data.Password.IsNullOrWhiteSpace())
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }
            if(data.Name.IsNullOrWhiteSpace()==false &&
                !data.Account.IsNullOrWhiteSpace()&&
                !data.Password.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "註冊成功";
            }


            return View(data);
        }
    }
}