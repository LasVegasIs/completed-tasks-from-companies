using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Concrete;
using KeysManager.Domain.Concrete;
using KeysManager.Domain.Entities;

namespace KeysManager.UI.PublicFunctions
{    
    //добавление данных в историю 
    public static class HistoryF
    {
        public static void AddDataToHistory(tbKey tkey, string cause)
        {
            EFHistoryChangeKeyValRepository HistChangeKey = new EFHistoryChangeKeyValRepository();//для сохранения истории
            tbHistoryChangeKeyVal tbh = new tbHistoryChangeKeyVal();//экземпляр дефалтового для значения при занесении в историю
              
            tbh.ID_KEY = tkey.ID;
            tbh.ID_DEV = tkey.ID_DEV;
            tbh.VALUE = tkey.VALUE;
            tbh.DATE_START = tkey.DATE_START;
            tbh.DATE_END = tkey.DATE_END;//дата по дефолту которая была 
            tbh.TEST = tkey.TEST;
            tbh.CAUSE = cause;//заполняем причину продления ключа
            tbh.MODIFY_DATE = DateTime.Now;//дата добавления
            HistChangeKey.InsertHistoryChangeKey(tbh);//запись старого значения в историю
            //return bool InsertedToHistory  = 
        }
    }
 
}