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
    public class EFUsersRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFUsersRepository()
        { }
        public IEnumerable<tbUser> UsersList
        {
            get { return context.tbUsers; }
        }

        public int UsersCount
        {
            get { return context.tbUsers.Count(); }
        }


        //Вставка записи
        public bool InsertUser(tbUser user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Added;
            return SaveData();
        }

        //Удаление записи
        public bool DeleteUser(tbUser user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            return SaveData();
        }

        //Update записи 
        public bool UpdateUser(tbUser user)
        {
            tbUser tbo = context.tbUsers.Where(t => t.ID == user.ID).First();
            tbo.ID_RIGHT = user.ID_RIGHT;
            tbo.LOGIN = user.LOGIN;
            tbo.PASSWORD = user.PASSWORD;
            return SaveData();

        }

        public tbUser FindUserById(int id)
        {
            var result = from r in context.tbUsers
                         where r.ID == id
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }

        public tbUser FindUserByName(string name)
        {
            var result = from r in context.tbUsers
                         where r.LOGIN == name
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }

        private bool SaveData()
        {
            return context.SaveChanges() > 0;
        }


    }
}
