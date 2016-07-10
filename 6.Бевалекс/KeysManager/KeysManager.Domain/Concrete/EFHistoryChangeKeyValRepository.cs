using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeysManager.Domain;
using Domain.Abstract;
using KeysManager.Domain.Entities;
using KeysManager.Domain.Abstract;

namespace KeysManager.Domain.Concrete
{
    public class EFHistoryChangeKeyValRepository: IHistoryChangeKeyValRepository
    {
        public EFDbContext context = new EFDbContext();
        public EFHistoryChangeKeyValRepository()
        { }

        public IEnumerable<tbHistoryChangeKeyVal> HistoryChangeKeyValList
        {

            get { return context.tbHistoryChangeKeyVals.OrderBy(d => d.MODIFY_DATE); }            
           
        }

        //Вставка записи
        public bool InsertHistoryChangeKey(tbHistoryChangeKeyVal tbh)
        {
            context.Entry(tbh).State = System.Data.Entity.EntityState.Added;
            return SaveData();
        }

        //Удаление записи
        public bool DeleteHistoryChangeKey(tbHistoryChangeKeyVal tbh)
        {
            context.Entry(tbh).State = System.Data.Entity.EntityState.Deleted;
            return SaveData();
        }

        public IEnumerable<tbHistoryChangeKeyVal> HistoryByIdKey(int idKey)
        {
            IEnumerable<tbHistoryChangeKeyVal> result = from h in context.tbHistoryChangeKeyVals
                            where h.ID_KEY == idKey
                            select h;
            return result;
        }

        private bool SaveData()
        {
            return context.SaveChanges() > 0;                
        }
    }
}
