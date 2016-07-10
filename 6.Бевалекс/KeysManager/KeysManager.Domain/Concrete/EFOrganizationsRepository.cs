using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeysManager.Domain;
using Domain.Abstract;
using KeysManager.Domain.Entities;
using System.Data.Entity.Validation;

namespace Domain.Concrete
{
    public class EFOrganizationsRepository : IOrganizationRepository
    {

        public EFDbContext context = new EFDbContext();
        public EFOrganizationsRepository()
        { }
        
        public IEnumerable<tbOrganization> OrganizationsList
        {

            get { return context.tbOrganizations; }            
           
        }

        //Вставка записи
        public bool InsertOrganization(tbOrganization Org)
        {
            context.Entry(Org).State = System.Data.Entity.EntityState.Added;
            return SaveData();
        }

        //Удаление записи
        public bool DeleteOrganization(tbOrganization Org)
        {
            context.Entry(Org).State = System.Data.Entity.EntityState.Deleted;
            return SaveData();
        }

        //Update записи 
        public bool UpdateOrganization(tbOrganization Org)
        {            
            tbOrganization tbo = context.tbOrganizations.Where(t => t.ID == Org.ID).First();
            tbo.LIM_KEYS = Org.LIM_KEYS;
            tbo.NAME = Org.NAME;
            tbo.NUM_CONTR = Org.NUM_CONTR;
            return SaveData();     

        }

        public tbOrganization FindOrganizationById(int id)
        {            
            var result = from r in context.tbOrganizations
                         where r.ID == id
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }

        private bool SaveData()
        {
            try
            {
                return context.SaveChanges() > 0;
                
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                string st = e.Message;
                return false;
            }
        }
    }
}
