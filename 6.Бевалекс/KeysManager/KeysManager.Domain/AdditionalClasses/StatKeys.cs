using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace KeysManager.Domain.AdditionalClasses
{
    public class StatKeys
    {
        [DisplayName("Общее количество ключей")]
        public int KeysFullCount { get; set; }

        [DisplayName("Количество лицензионных ключей")]
        public int KeysLicCount { get; set; }

        [DisplayName("Количество тестовых ключей")]
        public int KeysTestCount { get; set; }

        [DisplayName("Значение лимита ключей")]
        public int KeysLimCount { get; set; }

        [DisplayName("Количество действующих тестовых ключей")]
        public int KeysCurrenTestCount { get; set; }    

    }
}
