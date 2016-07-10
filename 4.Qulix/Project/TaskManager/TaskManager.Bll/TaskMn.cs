using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BusinessEntities.Collections;
using TaskManager.BusinessEntities;
using TaskManager.Domain;
using System.Transactions;
using TaskManager.Domain.Concrete;


namespace TaskManager.Bll
{
    public class TaskMn
    {
        public static TaskCollection GetList()
        {
            TaskCollection myCollection = TaskRepository.GetList();
            return myCollection;
        }

         public static TaskE GetItem(int id)
        { 
           TaskE mytask = TaskRepository.GetItem(id);
           return mytask;
        }

        public static bool Save(TaskE myTask)
        {
            using (TransactionScope myTransactionScope = new TransactionScope())
            {
                TaskRepository.Save(myTask); 
                myTransactionScope.Complete();
                return true;
            }
        }

        public static bool Delete(int taskId)
        {
            return TaskRepository.Delete(taskId);     
        }
    }
}
