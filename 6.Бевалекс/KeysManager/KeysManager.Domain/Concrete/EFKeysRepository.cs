using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeysManager.Domain;
using Domain.Abstract;
using KeysManager.Domain.Entities;
using KeysManager.Domain.AdditionalClasses;

namespace Domain.Concrete
{
    public class EFKeysRepository: IKeyRepository
    {
        EFDbContext context = new EFDbContext();

        public EFKeysRepository()
        { }

        public IEnumerable<tbKey> KeysList
        {
            get { return context.tbKeys; }
        }

        public IEnumerable<tbKey> FilterDataKeys(tbKey FindKey, bool withDates)
        {
            string ConditionWhere = "";
            string strQuery = "select * FROM tbKeys where ";             
            List<string> ConditionWhereList = new List<string>(); 
            if (FindKey.VALUE != string.Empty)
                ConditionWhereList.Add("VALUE like '%" + FindKey.VALUE +"%' ");

            if (withDates) { 
                if (FindKey.DATE_START != null)
                    ConditionWhereList.Add("DATE_START =" + "'" + FindKey.DATE_START + "' ");

                if (FindKey.DATE_END != null)
                     ConditionWhereList.Add("DATE_END =" + "'"+  FindKey.DATE_END + "' " );
            }
            
            ConditionWhereList.Add("TEST =" + Convert.ToInt32(FindKey.TEST).ToString() );

             
            for (int index = 0; index < ConditionWhereList.Count(); index ++ )
            {                            
                if (index == ConditionWhereList.Count() - 1)//если один или последний элемент
                    ConditionWhere += ConditionWhereList[index];
                else
                    ConditionWhere += ConditionWhereList[index] + " AND ";
            }         
            
             strQuery += ConditionWhere;           
             return context.tbKeys.SqlQuery(strQuery).ToList();            
        }

        //количество лицензионных ключей за организацией
        public int CountLicKeysByOrganization(int idOrg)
        {
            int countKeys = (from k in context.tbKeys
                             from d in context.tbDevices
                             where k.ID_DEV == d.ID &&
                                   d.ID_ORG == idOrg &&
                                   k.TEST == false
                             select k).Count();
            return countKeys;
        }

        public int CountKeyByDevice(int idDev)
        {
            int ckb = (from r in context.tbKeys where r.ID_DEV == idDev select r).Count();
            return ckb;
        }
        //запрос на более полную информацию по ключам
        public IEnumerable<FullInfoAboutKey> KeysListWithAdditInfo() //юзаем контекст для получения данных из таблицы 
        {
            List<FullInfoAboutKey> fiakl = new List<FullInfoAboutKey>();            
            var klw = from key in context.tbKeys
                     join dev in context.tbDevices on key.ID_DEV equals dev.ID
                     join org in context.tbOrganizations on dev.ID_ORG equals org.ID
                    select new
                    {
                        ID = key.ID,
                        NAME_ORG = org.NAME ,
                        CODE_KEY = dev.CODE_KEY,
                        NAME_OWNER = dev.NAME_OWNER,
                        VALUE = key.VALUE,
                        DATE_START = key.DATE_START,
                        DATE_END = key.DATE_END,
                        TEST= key.TEST
                    };

            foreach (var tt in klw)
            {
                FullInfoAboutKey fiak = new FullInfoAboutKey(); 
                fiak.ID = tt.ID;
                fiak.NameOrg = tt.NAME_ORG;
                fiak.Code_key = tt.CODE_KEY;                
                fiak.Name_owner = tt.NAME_OWNER;
                fiak.Key_value = tt.VALUE;  
                fiak.Date_start = tt.DATE_START;
                fiak.Date_end = tt.DATE_END;
                fiak.Test = tt.TEST;

                fiakl.Add(fiak);
            }

            return fiakl;               
        }

        public IEnumerable<StatKeys> StatKeysByOrg(int idOrg)
        {
            List<StatKeys> sl = new List<StatKeys>();
            StatKeys sk = new StatKeys();
            sk.KeysFullCount = (from key in context.tbKeys
                         join dev in context.tbDevices on key.ID_DEV equals dev.ID
                         join org in context.tbOrganizations on dev.ID_ORG equals org.ID
                         where org.ID == idOrg select key).Count();

            sk.KeysLicCount = (from key in context.tbKeys
                               join dev in context.tbDevices on key.ID_DEV equals dev.ID
                               join org in context.tbOrganizations on dev.ID_ORG equals org.ID
                               where org.ID == idOrg &&
                                     key.TEST == false
                               select key).Count();

            sk.KeysTestCount = (from key in context.tbKeys
                               join dev in context.tbDevices on key.ID_DEV equals dev.ID
                               join org in context.tbOrganizations on dev.ID_ORG equals org.ID
                               where org.ID == idOrg &&
                                     key.TEST == true
                               select key).Count();

            sk.KeysLimCount = (from c in context.tbOrganizations
                                          where c.ID == idOrg
                       select c.LIM_KEYS).Single<int>();
              
            sk.KeysCurrenTestCount = (from key in context.tbKeys
                                      join dev in context.tbDevices on key.ID_DEV equals dev.ID
                                      join org in context.tbOrganizations on dev.ID_ORG equals org.ID
                                      where org.ID == idOrg &&
                                            key.TEST == true &&
                                            key.DATE_END > DateTime.Today
                                      select key).Count();
            sl.Add(sk);
            return sl;            
        }

        //Вставка записи
        public bool InsertKey(tbKey tk)
        {            
            context.Entry(tk).State = System.Data.Entity.EntityState.Added;
            return SaveData();
        }

        //Удаление записи
        public bool DeleteKey(tbKey tk)
        {
            context.Entry(tk).State = System.Data.Entity.EntityState.Deleted;
            return SaveData();
        }

        //Update записи 
        public bool UpdateKey(tbKey tk)
        {
            tbKey tbk = context.tbKeys.Where(t => t.ID == tk.ID).First();
            tbk.VALUE = tk.VALUE;
            tbk.DATE_START = tk.DATE_START;
            tbk.DATE_END = tk.DATE_END;
            tbk.TEST = tk.TEST;
            
            return SaveData();
        }

        public tbKey FindKeyById(int id)
        {
            var result = from r in context.tbKeys
                         where r.ID == id
                         select r;
            if (result == null) return null;
            else return result.FirstOrDefault();
        }

        public tbKey FindKeyByDeviceID(int id)
        {
            var result = from d in context.tbKeys
                         where d.ID_DEV == id
                         select d;
            return result.FirstOrDefault();
        }

        private bool SaveData()
        {
            return context.SaveChanges() > 0;
        }

    }
}
