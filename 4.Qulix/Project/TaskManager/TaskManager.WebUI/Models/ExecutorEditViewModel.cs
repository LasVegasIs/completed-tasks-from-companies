using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.BusinessEntities;

namespace TaskManager.WebUI.Models
{
    public class ExecutorEditViewModel
    {
        private static bool stateInsert = false;

        [HiddenInput(DisplayValue = false)]
        public static bool StateInsert { get { return stateInsert; } set { stateInsert = value; } }

        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please enter a Second Name")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Please enter a Patronimic")]
        public string Patronimic { get; set; }

        public static ExecutorEditViewModel MapEntityToMv(Executor myExecutor)
        {
            return new ExecutorEditViewModel
            {
                ID = myExecutor.ID,
                FirstName = myExecutor.FirstName,
                SecondName = myExecutor.SecondName,
                Patronimic = myExecutor.Patronimic               
            };
        }


        public static Executor MapMvtoEntitiy(ExecutorEditViewModel eem)
        {
            return new Executor
            {
                ID = eem.ID,
                FirstName = eem.FirstName,
                SecondName = eem.SecondName,
                Patronimic = eem.Patronimic              
            };

        }
    }
}