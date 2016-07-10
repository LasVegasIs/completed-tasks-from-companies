using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Concrete;
using TaskManager.BusinessEntities.Collections;
using TaskManager.BusinessEntities;
using System.Transactions;

namespace TaskManager.Bll
{
    public class ExecutorMn
    {
        public static ExecutorCollection GetList()
        {
            ExecutorCollection myCollection = ExecutorRepository.GetList();
            return myCollection;
        }

        public static Executor GetItem(int id)
        {
            Executor myExecutor = ExecutorRepository.GetItem(id);
            return myExecutor;
        }

        public static void Save(Executor myExecutor)
        {
            using (TransactionScope myTransactionScope = new TransactionScope())
            {
                ExecutorRepository.Save(myExecutor);
                myTransactionScope.Complete();                
            }
        }

        public static bool Delete(int exkId)
        {
            return ExecutorRepository.Delete(exkId);
        }
    }
}
