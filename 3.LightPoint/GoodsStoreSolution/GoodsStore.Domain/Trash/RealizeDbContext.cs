using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodsStore.Domain.Abstract;
using GoodsStore.Domain.Entities;
using GoodsStore.Domain.Concrete;
using GoodsStore.WebUI.DBContext1;


namespace GoodsStore.Domain.DBContext1
{
    public class RealizeDbContext
    {
        public void InsertRowShop()
        {
            using (var db1 = new EFDbContext())
            {
                //db1.Shops.Add(new Shop() { Name = "My", Adress = "Nemanskaya 71", Operation = "12 00 - 11 00" });
               // db1.Shops.Add(new Table1() { idT = 22,Name = "Hello World" });
               // db1.SaveChanges();
             }
 
        }
        public void RealizeContext()
        {
            using (var db1 = new EFDbContext())
            {
                Shop shop1 = new Shop();
                db1.Shops.Add(shop1);
                db1.SaveChanges();
            }
        }
    }
}
