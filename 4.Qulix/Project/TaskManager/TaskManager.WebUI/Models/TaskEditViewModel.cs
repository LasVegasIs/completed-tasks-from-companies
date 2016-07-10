using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.BusinessEntities;

namespace TaskManager.WebUI.Models
{
    public class TaskEditViewModel
    {
        private static bool stateInsert = false;

        [HiddenInput(DisplayValue = false)]
        public static bool StateInsert { get { return stateInsert; } set { stateInsert = value; } }

        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Length row should be consits of 3 to 50 letters")]
        public string Name { get; set; }

       
        [Required(ErrorMessage = "Please enter a MainText")]
        public decimal Workload { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy'-'MM'-'dd}", ApplyFormatInEditMode = true)]
        public DateTime DateStart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy'-'MM'-'dd}", ApplyFormatInEditMode = true)]
        public DateTime DateEnd { get; set; }
        public int IdExecutor  { get; set; }

        public int IdState { get; set; }
        
        public static TaskEditViewModel MapEntityToMv(TaskE mytask)
        {
            return new TaskEditViewModel
            {
                ID = mytask.ID,
                Name = mytask.Name,
                Workload = mytask.Workload,
                DateStart = mytask.DateStart,
                DateEnd = mytask.DateEnd,
                IdState = mytask.IdState,
                IdExecutor = mytask.IdExecutor
            };
        }


        public static TaskE MapMvtoEntitiy(TaskEditViewModel tev)
        {
            return new TaskE
            {
                ID = tev.ID,
                Name = tev.Name,
                Workload = tev.Workload,
                DateStart = tev.DateStart,
                DateEnd = tev.DateEnd,
                IdState = tev.IdState,
                IdExecutor = tev.IdExecutor
            };
           
        }
       
    }
}