using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EbosTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using EbosTask.Repositories.Login;

namespace EbosTask.Controllers
{
    public class LoginController : Controller
    {
       private readonly  ILoginRepository _repository = null;
        public LoginController(ILoginRepository loginRepository)
        {
            this._repository = loginRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Roles = _repository.GetRoles().ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel user)
        {
           
            int res = _repository.LoginCheck(user);

            if (res == 1)
            {

                HttpContext.Session.SetString("Username", user.username.ToString());
                //string userName =  HttpContext.Session.GetString("Username");
                if (user.RoleID == "a02bcd3f-4704-4ac5-b8b5-4ff96638a185") // Manager
                {
                    HttpContext.Session.SetString("Manager", user.username.ToString());
                    // redirect to manage customer and reports
                    return RedirectToAction("getCustomer", "Customer");
                }
                else if(user.RoleID == "e506a6f4-cc6c-43b6-984b-8f2cbf2fafcd") // Employee
                {
                    HttpContext.Session.SetString("Employee", user.username.ToString());
                    // redirect to manage calls 
                    return RedirectToAction("Index", "Calls");
                }
            }
            else
            {
                TempData["LoginError"] = "Please enter correct login details....!";
                ViewBag.Roles = _repository.GetRoles().ToList();
            }
            return RedirectToAction("Index","Login");
        }
    }
}