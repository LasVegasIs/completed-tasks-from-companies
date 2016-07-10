using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.BusinessEntities
{
    public class Executor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronimic { get; set; }

        public string FullName
        {
            get
            {
                string tempValue = FirstName;
                tempValue += string.Format(" {0}", SecondName);
                tempValue += string.Format(" {0}", Patronimic);
                return tempValue;
             } 
        }
    }
}
