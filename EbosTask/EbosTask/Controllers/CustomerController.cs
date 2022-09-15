using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EbosTask.Repositories;
using EbosTask.Models;
using Microsoft.AspNetCore.Http;

namespace EbosTask.Controllers
{
    public class CustomerController : Controller
    {
        readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository repository)
        {
            
            this._customerRepository = repository;
        }

        [HttpGet]
        public IActionResult Customer()
        {
            string userName =  HttpContext.Session.GetString("Username");
            if (userName == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomersModel user)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    int res = _customerRepository.CreateCustomer(user);
                    if (res == 0)
                    {
                        TempData["msg"] = "data insert Failed";
                    }
                    return RedirectToAction("GetCustomer");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View();
        }
        public IActionResult GetCustomer()
        {
            return View();
        }
        public IActionResult GetCustomerData()
        {
            var List = _customerRepository.getCustomer();
            return Json(new { data = List });
        }
        public IActionResult DeleteCustomer(Guid id)
        {
            bool result = _customerRepository.DeleteCustomer(id);

            if (!result)
            {
                return Json("failed");
            }

            return Json("success");
        }
        [HttpGet]
        public IActionResult EditCustomer(Guid id)
        {
            return View(_customerRepository.getCustomer().Find(x => x.CustomerId == id));
         }
        [HttpPost]
        public IActionResult EditCustomer(CustomersModel cust)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerRepository.UpdateCustomer(cust);
                    return RedirectToAction("GetCustomer");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ViewBag.error = "Something is wrong..";
            return View();
           
        }
        public IActionResult Logout()
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(-1);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }
    }
}