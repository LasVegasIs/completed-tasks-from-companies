using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeysManager.Domain;
using Domain.Abstract;
using KeysManager.Domain.Entities;

namespace Domain.Concrete
{

    public class EFDevicesRepository: IDeviceRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFDevicesRepository()
        { }
        public IEnumerable<tbDevice> DevicesList
        {
            get { return context.tbDevices; }
        }

        public IEnumerable<tbDevice> DevicesLisByOrganization(int idOrg)
        {
             IEnumerable <tbDevice> Dbo = context.tbDevices.Where(t => t.ID_ORG == idOrg);
             return Dbo;
        }

        //Вставка записи
        public bool InsertDevice(tbDevice dev)
        {
            context.Entry(dev).State = System.Data.Entity.EntityState.Added;
            return SaveData();
        }

        //Удаление записи
        public bool DeleteDevice(tbDevice dev)
        {
            context.Entry(dev).State = System.Data.Entity.EntityState.Deleted;
            return SaveData();
        }

        //Update записи 
        public bool UpdateDevice(tbDevice dev)
        {
            tbDevice tbo = context.tbDevices.Where(t => t.ID == dev.ID).First();
            tbo.CODE_KEY = dev.CODE_KEY;
            tbo.NAME_OWNER = dev.NAME_OWNER;
            tbo.JOB_POSITION = dev.JOB_POSITION;
            tbo.ID_ORG = dev.ID_ORG;
            return SaveData();

        }

        public tbDevice FindDeviceById(int id)
        {
            var result = from r in context.tbDevices
                         where r.ID == id
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }

        //количество устройств за организацией
        public int CountDevicesByOrganization(int idOrg)
        {
             int countDev = (from k in context.tbDevices
                           where k.ID_ORG == idOrg
                           select k).Count();
             return countDev;
        }


        private bool SaveData()
        {
            return context.SaveChanges() > 0;
        }


    }
}
