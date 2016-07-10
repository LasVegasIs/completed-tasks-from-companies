using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Concrete;
using TaskManager.BusinessEntities.Collections;

namespace TaskManager.Bll
{
    public class StateMn
    {
        public static StateCollection GetList()
        {
            StateCollection myCollection = StateRepository.GetList();
            return myCollection;
        }
    }
}
