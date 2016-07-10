using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BusinessEntities.Collections;

namespace TaskManager.BusinessEntities
{
    public class TaskE
    {

    public TaskE()
    {
        Exec = new Executor();
        Stat = new State();
    }
    public int ID {get; set;}
    public string Name { get; set; }
    public decimal Workload { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }

    public int IdExecutor { get; set; }
    public int IdState { get; set; }

    public Executor Exec { get; set; }
    public State Stat { get; set; }

    }
}
