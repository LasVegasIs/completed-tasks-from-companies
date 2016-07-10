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
    public class TaskController : Controller
    {
        //Action for Main menu
        public ActionResult Index()
        {            
            return View();
        }
        //Action for List
        public ActionResult TaskList()
        {                      
            TaskCollection tc = TaskMn.GetList();
            return View(tc);
        }

        //Actions for Create Task 
        [HttpGet]        
        public ActionResult Create()
        {               
            ViewBag.Title = "Create Task";
            TaskEditViewModel.StateInsert = true; 
            FillDropDownMenus();                      
            return View("Edit", null);         
        }

        //Actions for Edit and Save Task
        [HttpGet]
        public ActionResult Edit(int taskId)
        {
            ViewBag.Title = "Edit Task";
            TaskEditViewModel.StateInsert = false; 
            TaskEditViewModel mytask = TaskEditViewModel.MapEntityToMv(TaskMn.GetItem(taskId));
            FillDropDownMenus();
            return View(mytask);
        }
        
        [HttpPost]
        public ActionResult Edit(TaskEditViewModel myTask)
        {   
           if (TaskEditViewModel.StateInsert) 
            {
                ModelState.Remove("Id");
            }

            if (myTask.DateEnd < myTask.DateStart)
                ModelState.AddModelError("DateEnd", "DateEnd should be greater than DateStart");

            if (ModelState.IsValid)
            {   

                TaskMn.Save(TaskEditViewModel.MapMvtoEntitiy(myTask));
                ViewBag["message"] = string.Format("{0} has been saved", myTask.Name);
                return RedirectToAction("TaskList");
            }
            else
            {
                // there is something wrong return Edit window with previous data
                FillDropDownMenus();
                return View(myTask);
            }
        }

        //Action for Delete Task
        public ActionResult Delete(int taskId)
        {
            bool res = TaskMn.Delete(taskId);
            if (res)
            {
                TempData["message"] = string.Format("{0} was deleted", "Task");
            }
            return RedirectToAction("TaskList");
        }

        //Fill List for View
        private void FillDropDownMenus()
        {
            SelectList states = new SelectList(StateMn.GetList(), "Id", "Name");
            ViewBag.States = states;
            SelectList executors = new SelectList(ExecutorMn.GetList(), "Id", "FullName");
            ViewBag.Executors = executors;
        }

    }
}
