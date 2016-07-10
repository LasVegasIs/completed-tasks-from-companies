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
    public class EFMemberOfRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFMemberOfRepository()
        { }
        public IEnumerable<tbMemberOf> MemberOfsList
        {
            get { return context.tbMemberOfs; }
        }

        public int MemberOfsCount
        {
            get { return context.tbMemberOfs.Count(); }
        }


        //Вставка записи
        public bool InsertMemberOf(tbMemberOf MemberOf)
        {
            context.Entry(MemberOf).State = System.Data.Entity.EntityState.Added;
            return SaveData();
        }

        //Удаление записи
        public bool DeleteMemberOf(tbMemberOf MemberOf)
        {
            context.Entry(MemberOf).State = System.Data.Entity.EntityState.Deleted;
            return SaveData();
        }

        public tbMemberOf FindByUserIdGroupID(int idGroup, int idUser)
        {
            tbMemberOf mo = (from m in context.tbMemberOfs
                            where m.ID_GROUP == idGroup &&
                            m.ID_USER == idUser
                             select m).FirstOrDefault();
                 return mo;
        }

        //Update записи 
        public bool UpdateMemberOf(tbMemberOf MemberOf)
        {
            tbMemberOf tbo = context.tbMemberOfs.Where(t => t.ID == MemberOf.ID).First();
            tbo.ID_GROUP = MemberOf.ID_GROUP;
            tbo.ID_USER = MemberOf.ID_USER;
            return SaveData();

        }

        private bool SaveData()
        {
            return context.SaveChanges() > 0;
        }


    }
}
