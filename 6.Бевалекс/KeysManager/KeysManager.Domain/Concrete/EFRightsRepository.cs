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
    public class EFRightsRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFRightsRepository()
        { }
        public IEnumerable<tbRight> RightsList
        {
            get { return context.tbRights; }
        }

        public tbRight FindRightById(int id)
        {
            var result = from r in context.tbRights
                         where r.ID == id
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }
    }
}
