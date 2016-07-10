using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace KeysManager.Domain.AdditionalClasses
{
    public class FullInfoAboutKey
    {
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Название организации")]
        public string NameOrg { get; set; }

        [DisplayName("Код ключа устройства")]
        public string Code_key { get; set; }

        [DisplayName("Фамилия владельца устройства")]
        public string Name_owner { get; set; }

        [DisplayName("Значение ключа")]
        public string Key_value { get; set; }

        [DisplayName("Дата начала периода")]
        public DateTime Date_start { get; set; }

        [DisplayName("Дата окончания периода")]

        public DateTime Date_end { get; set; }

        [DisplayName("Тестовый ключ")]        
        public bool Test { get; set; }
         
    }
}
