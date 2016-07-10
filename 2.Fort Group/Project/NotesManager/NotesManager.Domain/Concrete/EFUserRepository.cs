    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesManager.Domain.Abstract;
using NotesManager.Domain.Entities;

namespace NotesManager.Domain.Concrete
{
    public class EFUserRepository: IUserRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFUserRepository()
        {
            
        }          

        public IEnumerable<tbUser> AllUsers()
        {
            return context.tbUsers.ToList();
        }

        public bool AuthenticateUser(string name, string pass)
        {
            bool result = (from r in context.tbUsers
                         where r.NAME == name &&
                         r.PASSWORD == pass
                         select r).Count() > 0;
            return result;
        }

        public tbUser GetUser(string name, string pass)
       {
         tbUser result = (from r in context.tbUsers
                         where r.NAME == name &&
                         r.PASSWORD == pass
                         select r).FirstOrDefault();
         return result;
        }

        public bool AddUser(tbUser user)
        {

            context.tbUsers.Add(user);//insert recor     
    
           return SaveData();
        }

        private bool SaveData()
        {
            return context.SaveChanges() > 0;
        }

    }
}
