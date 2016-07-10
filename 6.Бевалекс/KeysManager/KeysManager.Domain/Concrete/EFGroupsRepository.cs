using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeysManager.Domain;
using Domain.Abstract;
using KeysManager.Domain.Entities;

namespace KeysManager.Domain.Concrete
{
    public class EFGroupsRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFGroupsRepository()
        { }
        public IEnumerable<tbGroup> GroupsList
        {
            get { return context.tbGroups; }
        }


        //Вставка записи
        public bool InsertGroup(tbGroup group)
        {
            context.Entry(group).State = System.Data.Entity.EntityState.Added;            
            return SaveData();
        }

        //Удаление записи
        public bool DeleteGroup(tbGroup group)
        {
            context.Entry(group).State = System.Data.Entity.EntityState.Deleted;
            return SaveData();
        }

        //Update записи 
        public bool UpdateGroup(tbGroup group)
        {
            tbGroup tbo = context.tbGroups.Where(t => t.ID == group.ID).First();
            tbo.ID_RIGHT = group.ID_RIGHT;
            tbo.NAME = group.NAME;            
           return SaveData();

        }

        public tbGroup FindGroupById(int id)
        {
            var result = from r in context.tbGroups
                         where r.ID == id
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }

        public IEnumerable<tbGroup> FindGroupsByUserId(int IdUser)
        {
            IEnumerable<tbGroup> lGrs = from gr in context.tbGroups
                                        from mp in context.tbMemberOfs
                                        where gr.ID == mp.ID_GROUP &&
                                              mp.ID_USER == IdUser
                                        select gr;
            return lGrs;

        }

        private bool SaveData()
        {
            return context.SaveChanges() > 0;
        }


    }
}
