using System;
using System.Collections.Generic;
using EbosTask.Models;
using EbosTask.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EbosTask.Controllers
{
    public class CallsController : Controller
    {
       private readonly ICallsRepository _CallRepository = null;

        public CallsController(ICallsRepository repository)
        {
            this._CallRepository = repository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
        public IActionResult GetCallsData()
        {
            var result = _CallRepository.GetCalls();
         
            return Json(new { data = result });
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.lstNumbers = _CallRepository.GetCustNumbers();
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(CallsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int result = _CallRepository.AddCall(model);
                    if (result == 0)
                    {
                        ViewBag.addCallError = "Call added failed.";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return RedirectToAction("Index","Calls");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_CallRepository.GetCalls().Find(x => x.Callid == id));

        }
        [HttpPost]
        public IActionResult Edit(CallsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                  bool result =  _CallRepository.UpdateCalls(model);
                    if(!result)
                    {
                        ViewBag.editCallError = "Call update failed.";
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return RedirectToAction("Index","Calls");
        }
        public IActionResult Delete(int id)
        {
            
            bool result =  _CallRepository.DeleteCall(id);
            if (!result)
            {
                return Json("failed");
            }
            return Json("success");
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