using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Concrete;
using KeysManager.Domain.Concrete;
using KeysManager.Domain.Entities;

namespace KeysManager.UI.PublicFunctions
{    
    //добавление данных в историю 
    public static class KeyF
    {
        public static string GetNewValueKey()
        {
            return Guid.NewGuid().GetHashCode().ToString();
        }
    }
 
}



