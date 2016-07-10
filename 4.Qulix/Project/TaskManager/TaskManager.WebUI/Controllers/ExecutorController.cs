using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.Bll;
using TaskManager.BusinessEntities.Collections;
using TaskManager.BusinessEntities;
using TaskManager.WebUI.Models;


namespace TaskManager.WebUI.Controllers
{
    public class ExecutorController : Controller
    {      

        public ActionResult ExecutorList()
        {
            ExecutorCollection ec = ExecutorMn.GetList();
            return View(ec);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Title = "Create Executor";
            ExecutorEditViewModel.StateInsert = true;           
            return View("Edit", null);
        }

        [HttpGet]
        public ActionResult Edit(int ExecutorId)
        {
            ViewBag.Title = "Edit Executor";
            ExecutorEditViewModel.StateInsert = false;
            ExecutorEditViewModel myexec = ExecutorEditViewModel.MapEntityToMv(ExecutorMn.GetItem(ExecutorId));
            return View(myexec);
        }

        [HttpPost]
        public ActionResult Edit(ExecutorEditViewModel myexec)
        {
            if (ExecutorEditViewModel.StateInsert)
            {
                ModelState.Remove("Id");
            }
            
            if (ModelState.IsValid)
            {   ExecutorMn.Save(ExecutorEditViewModel.MapMvtoEntitiy(myexec));
                TempData["message"] = string.Format("{0} has been saved", myexec.FirstName);
                return RedirectToAction("ExecutorList");
            }
            else
            {
                // there is something wrong return Edit window with previous data                
                return View(myexec);
            }
        }

        public ActionResult Delete(int ExecutorId)
        {
            bool res = ExecutorMn.Delete(ExecutorId);
            if (res)
            {
                TempData["message"] = string.Format("{0} was deleted", "Executor");
            }
            return RedirectToAction("ExecutorList");
        }

    }
}
